using BrightIdeasSoftware;
using KittingMst_2.Forms;
using KittingMst_2.Karty_Technologiczne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittingMst_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrdersList.dgvOrders = dgvOrdersList;
            OrdersList.cbHideFinished = cbHideFinished;
            OrdersList.cbNewOnly = cbNewOnly;
            SelectedOrder.lvSelectedOrder = lvSelectedOrder;
            ProductStructureTree.treeProductStructure = treeProductStructure;
            LedUsedInOrder.lvLedUsedForOrder = lvLedUsedForOrder;
            LedUsedInOrder.lvLedsSummary = lvLedsSummary;
            VisualEffects.loadingTransitionTimer = loadingTransitionTimer;

#if DEBUG
            GlobalParameters.release = false;
#endif
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private static async Task LoadDbAsync()
        {
            List<Task> tasksList = new List<Task>();
            tasksList.Add(Task.Run(() => DevTools.LoadDtDb()));
            tasksList.Add(Task.Run(() => OrdersList.LoadOrders()));
            tasksList.Add(Task.Run(() => LedCollectiveDb.LoadDb()));
            tasksList.Add(Task.Run(() => OrdersList.LoadTestersDict()));
            await Task.WhenAll(tasksList);
            OrdersList.FillOutOrdersListGrid();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pbRefresh.Visible = true;
            await LoadDbAsync();
            pbRefresh.Visible = false;
        }

        private void cbHideFinished_CheckedChanged(object sender, EventArgs e)
        {
            OrdersList.FillOutOrdersListGrid();
        }

        private void dgvOrdersList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdersList.SelectedRows.Count > 0) 
            {
                int rowIndx = dgvOrdersList.SelectedRows[0].Index;
                if (rowIndx > -1)
                {
                    string orderNo = dgvOrdersList.Rows[rowIndx].Cells["ColOrderNo"].Value.ToString();
                    SelectedOrder.selectedOrder = OrdersList.orders[orderNo];

                    var dtModel00 = MST.MES.DtTools.GetDtModel00(SelectedOrder.selectedOrder.modelId, DevTools.dtDb);
                    ProductStructureTree.MakeTreeViewSource(dtModel00);

                    lvLedUsedForOrder.Items.Clear();
                    lvLedsSummary.Items.Clear();

                    bAddLeds.Visible = false;

                    LedUsedInOrder.ShowAllowedLeds();
                }
            }
        }

        private void lvSelectedOrder_CellClick(object sender, CellClickEventArgs e)
        {

        }

        private async void bLoadLeds_Click(object sender, EventArgs e)
        {
            pbLedLoad.Visible = true;
            await LedUsedInOrder.LoadLeds(SelectedOrder.selectedOrder.orderNo);
            pbLedLoad.Visible = false;
            bAddLeds.Visible = true;
            LedUsedInOrder.UpdateLedSummary();
            ComponentsAvailability.FillOutGrid();
        }

        private void lvLedUsedForOrder_FormatCell(object sender, FormatCellEventArgs e)
        {
            
        }

        private void lvSelectedOrder_Click(object sender, EventArgs e)
        {
            
        }

        private async void bRefresh_Click(object sender, EventArgs e)
        {
            pbRefresh.Visible = true;
            await LoadDbAsync();
            pbRefresh.Visible = false;
        }

        private void lvSelectedOrder_ButtonClick(object sender, CellClickEventArgs e)
        {
            if(e.Item.Text == "Plan wysyłki:")
            {
                using (ChangeDateForm changeForm = new ChangeDateForm())
                {
                    if(changeForm.ShowDialog() == DialogResult.OK)
                    {
                        MST.MES.SqlOperations.Kitting.UpdateOrderPlannedEndDate(SelectedOrder.selectedOrder.orderNo, changeForm.selectedDate);
                        SelectedOrder.selectedOrder.plannedEnd = changeForm.selectedDate;
                        dgvOrdersList.SelectedRows[0].Cells["ColPlannedEnd"].Value = changeForm.selectedDate;
                        SelectedOrder.UpdateSelectedOrderListView();
                    }
                }
            }

            if (e.Item.Text == "Ilość do produkcji:")
            {
                using (ChangeProductionQtyForm changeForm = new ChangeProductionQtyForm())
                {
                    if (changeForm.ShowDialog() == DialogResult.OK)
                    {
                        MST.MES.SqlOperations.Kitting.UpdateOrderQty(SelectedOrder.selectedOrder.orderNo, changeForm.newQty);
                        SelectedOrder.selectedOrder.orderedQty = changeForm.newQty;
                        dgvOrdersList.SelectedRows[0].Cells["ColProductionQty"].Value = changeForm.newQty;
                        SelectedOrder.UpdateSelectedOrderListView();
                    }
                }
            }

            if (e.Item.Text == "Linia SMT:")
            {
                using (ChooseLineOrTester changeForm = new ChooseLineOrTester(ChooseLineOrTester.Type.SmtLines, OrdersList.testerIdDict))
                {
                    if (changeForm.ShowDialog() == DialogResult.OK)
                    {
                        MST.MES.SqlOperations.Kitting.UpdateSmtLine(SelectedOrder.selectedOrder.orderNo, changeForm.result);
                        SelectedOrder.selectedOrder.smtLine = changeForm.result;
                        SelectedOrder.UpdateSelectedOrderListView();
                    }
                }
            }

            if (e.Item.Text == "Tester:")
            {
                using (ChooseLineOrTester changeForm = new ChooseLineOrTester(ChooseLineOrTester.Type.Testers, OrdersList.testerIdDict))
                {
                    if (changeForm.ShowDialog() == DialogResult.OK)
                    {
                        MST.MES.SqlOperations.Kitting.UpdateTesterId(SelectedOrder.selectedOrder.orderNo, changeForm.result);
                        SelectedOrder.selectedOrder.testerId = changeForm.result;
                        SelectedOrder.UpdateSelectedOrderListView();
                    }
                }
            }

            if(e.Item.Text == "Zlecenie powiązane:")
            {
                using(EditConnectedOrder conOrderForm = new EditConnectedOrder())
                {
                    if(conOrderForm.ShowDialog() == DialogResult.OK)
                    {
                        SelectedOrder.UpdateSelectedOrderListView();
                    }
                }
            }
        }

        private void bAddLeds_Click(object sender, EventArgs e)
        {
            using(ScanLedQr scanForm = new ScanLedQr())
            {
                if (scanForm.ShowDialog() == DialogResult.OK) 
                {
                    if (!LedUsedInOrder.AllowedLedsForSelectedOrder.Bins12NcForOrder.Contains(scanForm.graffitiCompData.Nc12_Formated_Rank))
                    {
                        MessageBox.Show("Zeskanowany kod 12NC jest niezgodny z kodem zaplanowanym do produkcji." + Environment.NewLine
                                         + "Dopuszczlne kody 12NC:" + Environment.NewLine
                                         + string.Join(Environment.NewLine, SelectedOrder.selectedOrder.ledsChoosenByPlanner));
                        return;
                    }

                    string binLetter = LedUsedInOrder.AllowedLedsForSelectedOrder.GetBinLetter(scanForm.nc12);
                    if (GlobalParameters.release)
                    {
                        //MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinIdLocation(scanForm.nc12, scanForm.id, SelectedOrder.selectedOrder.orderNo, binLetter, "Kitting");
                        Graffiti.MST.ComponentsTools.UpdateDbData.UpdateComponentLocation(scanForm.fullQrText, Graffiti.MST.ComponentsLocations.Kitting);
                        scanForm.graffitiCompData.Location = Graffiti.MST.ComponentsLocations.Kitting;
                        if (scanForm.printLabel)
                        {
                            PrintReelLabel.Print(scanForm.fullQrText);
                        }
                    }
                    LedUsedInOrder.AddLedReel(scanForm.graffitiCompData);
                }
            }
        }

        private void lvLedUsedForOrder_ButtonClick(object sender, CellClickEventArgs e)
        {
            if(e.SubItem.Text != SelectedOrder.selectedOrder.orderNo)
            {
                

                DialogResult dialogResult = MessageBox.Show($"Czy na pewno chcesz przypisać tą diodę do zlecenia {SelectedOrder.selectedOrder.orderNo}?", "Potwierdź", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string nc12 = e.Item.SubItems[0].Text;
                    string id = e.Item.SubItems[1].Text;
                    string binLetter = LedUsedInOrder.AllowedLedsForSelectedOrder.GetBinLetter(nc12);
                    if(binLetter == null)
                    {

                    }

                    MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinIdLocation(nc12, id, SelectedOrder.selectedOrder.orderNo, binLetter, "Kitting");
                }
                
            }
        }

        private void bKT_Click(object sender, EventArgs e)
        {

            var excPkg = ExcelOperations.GetExcelPackage(SelectedOrder.selectedOrder.modelId);// currentOrder.modelId);
            if (excPkg != null)
            {
                string additionalComment = "";// lProdWerehouseStock.Text != "" ? $"Wyrób znajduje się na regale: {lProdWerehouseStock.Text}" : "";
                if (ProductionStock.CurrentStock.Count > 0)
                {
                    additionalComment = $"Wyrób znajduje się na regale: {string.Join(", ", ProductionStock.CurrentStock)}";
                }

                string tempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ExcelOperations.ExcelParameters.tempFileName);
                for (int i = 0; i < 20; i++) //try 20 filenames for tempFile
                {
                    tempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{i}_{ExcelOperations.ExcelParameters.tempFileName}");
                    if (!ExcelOperations.IsFileLocked(new FileInfo(tempFile)))
                    {
                        break;
                    }
                    if (i == 14)
                    {
                        MessageBox.Show("Nie można uzystać dostępu do programu Excel. Zamknij wszystkie okna Excel i spróbuj ponownie." + Environment.NewLine + "W razie dalszych problemów uruchom ponownie komputer");
                        return;
                    }
                }

                ExcelOperations.FillOutExcelData(ref excPkg, false, additionalComment);
                ExcelOperations.SaveToExcel(excPkg, tempFile);
                Process.Start(tempFile);
            }
        }

        private void cbNewOnly_CheckedChanged(object sender, EventArgs e)
        {
            OrdersList.FillOutOrdersListGrid();
        }

        private void lvSelectedOrder_ItemsAdding(object sender, ItemsAddingEventArgs e)
        {

        }

        private void lvSelectedOrder_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.CellValue == null) return;
            if(e.CellValue.ToString() == "Brak" || e.CellValue.ToString() == "-1")
            {
                e.SubItem.BackColor = Color.Red;
                e.SubItem.ForeColor = Color.White;
            }
        }
    }
}
