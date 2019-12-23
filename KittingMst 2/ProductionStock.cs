using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KittingMst_2.SelectedOrder;

namespace KittingMst_2
{
    internal class ProductionStock
    {
        public static List<string> CurrentStock = new List<string>();
        public static void CheckProdStock(ref List<ListViewColumns> ledSummarySource)
        {
            CurrentStock.Clear();
            var prodWerehoueStock = MST.MES.SqlOperations.ConnectDB.CheckHowManyProductsOnProdWerehouse(selectedOrder.modelId + "46");
            if (prodWerehoueStock.Count > 0)
            {
                foreach (var locationEntry in prodWerehoueStock)
                {
                    ledSummarySource.Add(new ListViewColumns
                    {

                    });

                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = "Końcówki zleceń"
                    });

                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = locationEntry.Key,
                        second = locationEntry.Value+"szt."
                    });

                    CurrentStock.Add($"{locationEntry.Key} - {locationEntry.Value}szt.");
                }
            }
        }
    }
}
