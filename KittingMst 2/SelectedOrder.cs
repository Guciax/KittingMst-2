using BrightIdeasSoftware;
using MST.MES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MST.MES.OrderStructureByOrderNo;

namespace KittingMst_2
{
    public class SelectedOrder
    {
        public static ObjectListView lvSelectedOrder;
        private static Kitting _selectedOrder;
        private static List<ListViewColumns> listViewSource = new List<ListViewColumns>();
        
        public static string SmtLine
        {
            get
            {
                return _selectedOrder.smtLine > 0 ? $"SMT{_selectedOrder.smtLine}" : "Brak";
            }
        }
        public static string TesterName
        {
            get
            {
                return _selectedOrder.testerId > 0 ? OrdersList.testerIdDict[_selectedOrder.testerId] : "Brak";
            }
        }
        public class ListViewColumns
        {
            public string first { get; set; }
            public string second { get; set; }
            public string edit { get; set; }
        }

        public static Kitting selectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                UpdateSelectedOrderListView();
            }
        }

        public static void UpdateSelectedOrderListView()
        {
            listViewSource = MakeListViewSource();
            lvSelectedOrder.SetObjects(listViewSource);
        }

        private static List<ListViewColumns> MakeListViewSource()
        {
            List<ListViewColumns> result = new List<ListViewColumns>();
            var dtModel00 = MST.MES.DtTools.GetDtModel00(_selectedOrder.modelId, DevTools.dtDb);

            result.Add(new ListViewColumns
            {
                first= "Numer:",
                second= _selectedOrder.orderNo
            });
            result.Add(new ListViewColumns
            {
                first = "10NC:",
                second = _selectedOrder.modelId_12NCFormat
            });
            result.Add(new ListViewColumns
            {
                first = "Nazwa:",
                second = _selectedOrder.ModelName
            });
            result.Add(new ListViewColumns
            {
                first = "Start:",
                second = _selectedOrder.kittingDate.ToString("dd-MMM-yyyy HH:mm")
            });
            result.Add(new ListViewColumns
            {
                first = "Plan wysyłki:",
                second = _selectedOrder.plannedEnd.ToString("dd-MMM-yyyy HH:mm"),
                edit = "Zmień"
            });
            result.Add(new ListViewColumns
            {
                first = "Ilość do wysyłki:",
                second = _selectedOrder.shippingQty.ToString()
            });
            result.Add(new ListViewColumns
            {
                first = "Ilość do produkcji:",
                second = _selectedOrder.orderedQty.ToString(),
                edit = "Zmień"
            });
            result.Add(new ListViewColumns
            {
                first = "Linia SMT:",
                second = SmtLine,
                edit = "Zmień"
            });
            result.Add(new ListViewColumns
            {
                first = "Tester:",
                second = TesterName,
                edit = "Zmień"
            });

            if (dtModel00 != null)
            {
                result.Add(new ListViewColumns
                {
                    first = "Dane wyrobu:",
                    second = ""
                });
                result.Add(new ListViewColumns
                {
                    first = "Ilość LED:",
                    second = DtTools.GetLedCount(dtModel00).ToString()
                });
                result.Add(new ListViewColumns
                {
                    first = "Ilość CONN:",
                    second = DtTools.GetConnCount(dtModel00).ToString()
                });
                result.Add(new ListViewColumns
                {
                    first = "Ilość RES:",
                    second = DtTools.GetResCount(dtModel00).ToString()
                });
                result.Add(new ListViewColumns
                {
                    first = "Ilość PCB/MB:",
                    second = DtTools.GetPcbPerMbCount(dtModel00).ToString()
                });
                result.Add(new ListViewColumns
                {
                    first = "MB:",
                    second = DtTools.GetMb12NC(dtModel00).ToString()
                });

                

            }

            result.Add(new ListViewColumns
            {
                first = "Zlecenie powiązane:",
                second = _selectedOrder.connectedOrder,
                edit = "Zmień"
            });

            return result;
        }
        private static void UpdateSelectedOrderView()
        {
            var dtModel00 = MST.MES.DtTools.GetDtModel00(_selectedOrder.modelId, DevTools.dtDb);
            
            lvSelectedOrder.Items.Clear();
            lvSelectedOrder.Items.Add(NewItem("Numer:", _selectedOrder.orderNo));
            lvSelectedOrder.Items.Add(NewItem("10NC:", _selectedOrder.modelId_12NCFormat));
            lvSelectedOrder.Items.Add(NewItem("Start:", _selectedOrder.kittingDate.ToString("dd-MMM-yyyy HH:mm")));
            lvSelectedOrder.Items.Add(NewItem("Plan wysyłki:", _selectedOrder.plannedEnd.ToString("dd-MMM-yyyy HH:mm")));
            lvSelectedOrder.Items.Add(NewItem("Ilość do wysyłki:", _selectedOrder.shippingQty.ToString()));
            lvSelectedOrder.Items.Add(NewItem("Ilość do produkcji:", _selectedOrder.orderedQty.ToString()));

            if(dtModel00 != null)
            {
                lvSelectedOrder.Items.Add(NewItem("Dane wyrobu:", ""));
                lvSelectedOrder.Items.Add(NewItem("Ilość LED:", DtTools.GetLedCount(dtModel00).ToString()));
                lvSelectedOrder.Items.Add(NewItem("Ilość CONN:", DtTools.GetConnCount(dtModel00).ToString()));
                lvSelectedOrder.Items.Add(NewItem("Ilość RES:", DtTools.GetResCount(dtModel00).ToString()));
                lvSelectedOrder.Items.Add(NewItem("Ilość PCB/MB:", DtTools.GetPcbPerMbCount(dtModel00).ToString()));
                lvSelectedOrder.Items.Add(NewItem("MB:", DtTools.GetMb12NC(dtModel00).ToString()));
            }
            lvSelectedOrder.AutoResizeColumns();
        }

        private static OLVListItem NewItem(string first, string second)
        {
            OLVListItem result = new OLVListItem(first);
            //result.SubItems.Add();
            OLVListSubItem newSub = new OLVListSubItem();
            newSub.Text = second;
            result.SubItems.Add(newSub);
            return result;
        }
    }
}
