using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MST.MES.OrderStructureByOrderNo;

namespace KittingMst_2
{
    public class OrdersList
    {
        public static DataGridView dgvOrders;
        public static CheckBox cbHideFinished;
        public static CheckBox cbNewOnly;
        public static Dictionary<int, string> testerIdDict = new Dictionary<int, string>();

        public static Dictionary<string, Kitting> orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
            }
        }
        private static Dictionary<string, Kitting> _orders;
        public static void LoadTestersDict()
        {
            testerIdDict = MST.MES.SqlDataReaderMethods.LedTest.TesterIdToName();
        }
        public static void LoadOrders()
        {
            orders = MST.MES.SqlDataReaderMethods.Kitting.GetKittingDataForClientGroup(MST.MES.SqlDataReaderMethods.Kitting.clientGroup.MST, 100);
        }

        public static void FillOutOrdersListGrid()
        {
            if (_orders == null) return;
            dgvOrders.Rows.Clear();

            foreach (var orderEntry in _orders)
            {
                if (cbHideFinished.Checked & orderEntry.Value.endDate > orderEntry.Value.kittingDate) continue;
                if (cbNewOnly.Checked & orderEntry.Value.orderedQty > -1) continue;

                DateTime? plannedEnd = null;
                if (orderEntry.Value.plannedEnd.Year > 2000) plannedEnd = orderEntry.Value.plannedEnd;

                DateTime? endDate = null;
                if (orderEntry.Value.endDate > orderEntry.Value.kittingDate) plannedEnd = orderEntry.Value.endDate;

                dgvOrders.Rows.Add(orderEntry.Value.orderNo,
                                   orderEntry.Value.modelId_12NCFormat,
                                   orderEntry.Value.kittingDate,
                                   endDate,
                                   plannedEnd,
                                   orderEntry.Value.shippingQty,
                                   orderEntry.Value.orderedQty);

            }

            MST.MES.DgvTools.ColumnsAutoSize(dgvOrders, DataGridViewAutoSizeColumnMode.AllCells);
        }
    }
}
