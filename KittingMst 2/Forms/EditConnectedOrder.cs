using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittingMst_2.Forms
{
    public partial class EditConnectedOrder : Form
    {
        public EditConnectedOrder()
        {
            InitializeComponent();
        }

        private void EditConnectedOrder_Load(object sender, EventArgs e)
        {
            cbOrderNumber.Items.AddRange(OrdersList.orders.Where(o => o.Value.endDate < o.Value.kittingDate).Select(o => o.Key).ToArray());
        }

        private void cbOrderNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OrdersList.orders.ContainsKey(cbOrderNumber.Text))
            {
                return;
            }

            var selectedOrder = OrdersList.orders[cbOrderNumber.Text];
            lOrderInfo.Text = string.Join(Environment.NewLine,
                                          $"Model 10NC: {selectedOrder.modelId_12NCFormat}",
                                          $"Model nazwa: {selectedOrder.ModelName}",
                                          $"Ilość do wysyłki: {selectedOrder.shippingQty}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!OrdersList.orders.ContainsKey(cbOrderNumber.Text))
            {

                return;
            }
            if (nudPcbOnMbCount.Value < 1)
            {

                return;
            }

            MST.MES.SqlOperations.Kitting.UpdateConnectedOrder(SelectedOrder.selectedOrder.orderNo, cbOrderNumber.Text, (int)nudPcbOnMbCount.Value);
            SelectedOrder.selectedOrder.connectedOrder = cbOrderNumber.Text;
            SelectedOrder.selectedOrder.connectedOrderPcbOnMb = (int)nudPcbOnMbCount.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MST.MES.SqlOperations.Kitting.UpdateConnectedOrder(SelectedOrder.selectedOrder.orderNo, "", 0);
            SelectedOrder.selectedOrder.connectedOrder = "";
            SelectedOrder.selectedOrder.connectedOrderPcbOnMb = 0;
            this.DialogResult = DialogResult.OK;
        }
    }
}
