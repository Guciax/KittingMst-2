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
    public partial class ChangeProductionQtyForm : Form
    {
        public int newQty = 0;
        private double pcbPerMb = 0;
        public ChangeProductionQtyForm()
        {
            InitializeComponent();
        }

        private void ChangeProductionQtyForm_Load(object sender, EventArgs e)
        {
            var dtModel = MST.MES.DtTools.GetDtModel00(SelectedOrder.selectedOrder.modelId, DevTools.dtDb);
            string pcbPerMbString = "Brak danych";
            if (dtModel != null)
            {
                pcbPerMb = MST.MES.DtTools.GetPcbPerMbCount(dtModel);
                pcbPerMbString = pcbPerMb.ToString();
            }
            lModelInfo.Text += Environment.NewLine +
                                $"12NC: {SelectedOrder.selectedOrder.modelId_12NCFormat}" +
                                Environment.NewLine + $"Ilość PCB/MB: {pcbPerMb}";

            textBox1.Text = SelectedOrder.selectedOrder.orderedQty.ToString();
            this.ActiveControl = textBox1;
            textBox1.SelectAll();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lMbQtyCalculation.Text = "Ilość MB do zlecenia:";
            if(textBox1.Text != "")
            {
                double orderQty = 0;
                if(!double.TryParse(textBox1.Text, out orderQty))
                {
                    textBox1.Text = "0";
                }

                var mbCount = Math.Round(orderQty / pcbPerMb, 2);
                lMbQtyCalculation.Text = Environment.NewLine + $"dla ilości {orderQty} => {mbCount} szt. MB";
                if (mbCount % 1 != 0)
                {
                    lMbQtyCalculation.Text += Environment.NewLine + $"Aby zaokrąglić do pełnych MB wpisz: {Math.Ceiling(mbCount) * pcbPerMb}";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newQty = int.Parse(textBox1.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
