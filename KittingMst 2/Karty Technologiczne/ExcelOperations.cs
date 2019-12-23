using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittingMst_2.Karty_Technologiczne
{
    public class ExcelOperations
    {
        public class BinDescription
        {
            public string nc12Address;
            public string nameAddress;
            public string quantity;
        }

        public class ExcelParameters
        {
            public static string katyTechnologiczneDirPath = @"Y:\Manufacturing_Center\Integral Quality Management\Karty technologiczne\Karty technologiczne LED\";
            public static string orderNoAddress = "L4";
            public static string quantityProductionAddress = "L8";
            public static string quantityShippingAddress = "L10";
            public static string additionalComment = "B42";
            public static string tempFileName = "kartaTechnologiczna.xlsx";

            public static Dictionary<string, BinDescription> binDescriptions = new Dictionary<string, BinDescription>
            {
                {"A", new BinDescription{nameAddress="C19",nc12Address="E19", quantity="F19"} },
                {"B", new BinDescription{nameAddress="C20",nc12Address="E20", quantity="F20"} },
                {"C", new BinDescription{nameAddress="C21",nc12Address="E21", quantity="F21"} },
                {"D", new BinDescription{nameAddress="C22",nc12Address="E22", quantity="F22"} },
            };
        }

        public static ExcelPackage GetExcelPackage(string nc12)
        {
            string filePath = Path.Combine(ExcelParameters.katyTechnologiczneDirPath, $"{nc12}46.xlsx");
            if (!Directory.Exists(@"Y:\"))
            {
                MessageBox.Show($"Brak dostępu do dysku Y:");
                return null;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Brak karty technologicznej dla modelu: {nc12}46");
                return null;
            }

            return new ExcelPackage(new System.IO.FileInfo(filePath));
        }

        public static void FillOutExcelData(ref ExcelPackage excelPck, 
                                            bool nonStandardOrder,
                                            string additionalComment)
        {
            var ordersHistoryForModel = MST.MES.SqlDataReaderMethods.Kitting.GetKittingDataForModel(SelectedOrder.selectedOrder.modelId);
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.orderNoAddress].Value = SelectedOrder.selectedOrder.orderNo.ToString();
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.quantityProductionAddress].Value = SelectedOrder.selectedOrder.orderedQty.ToString();
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.quantityShippingAddress].Value = SelectedOrder.selectedOrder.shippingQty.ToString();

            if (nonStandardOrder)
            {
                excelPck.Workbook.Worksheets[1].Row(3).Height = 50;
                var titleCell = excelPck.Workbook.Worksheets[1].Cells["B3"];
                titleCell.Value += Environment.NewLine + "ZLECENIE NIESTANDARDOWE - STRUKTURA WYROBU MOŻE SIĘ NIE ZGADZAĆ";
                titleCell.Style.WrapText = true;

                var titleRange = excelPck.Workbook.Worksheets[1].Cells["B3:N3"];
                titleRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                titleRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                titleRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                titleRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
            }

            char binId = 'A';
            foreach (var ledBin in SelectedOrder.selectedOrder.ledsChoosenByPlanner) 
            {
                var name = LedUsedInOrder.GenerateLedName(ledBin);
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].nameAddress].Value = name;
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].nc12Address].Value = ledBin.Insert(4, " ").Insert(8, " ");
                var dtModel = MST.MES.DtTools.GetDtModel00(SelectedOrder.selectedOrder.modelId, DevTools.dtDb);
                if(dtModel!=null & LedUsedInOrder.AllowedLedsForSelectedOrder.AllBinsHaveCollective())
                {
                    excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].quantity].Value = LedUsedInOrder.AllowedLedsForSelectedOrder.GetNumberOfLedForMember12Nc(ledBin, dtModel);
                }
                
                binId++;
            }

            if (!string.IsNullOrWhiteSpace(additionalComment))
            {
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.additionalComment].Value += Environment.NewLine + additionalComment;
            }
            if (ordersHistoryForModel.Count < 2)
            {
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.additionalComment].Value += Environment.NewLine + "*** Uwaga! Pierwsze zlecenie produkcyjne dla tego modelu! ***";
            }
        }

        public static void SaveToExcel(ExcelPackage excelPck, string tempFile)
        {
            //var bytes = excelPck.GetAsByteArray();
            //System.IO.File.WriteAllBytes(tempFile, bytes);
            //excelPck.SaveAs(new FileInfo(tempFile));

            Stream stream = File.Create(tempFile);
            excelPck.SaveAs(stream);
            stream.Close();

        }

        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            if (!file.Exists) return false;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}
