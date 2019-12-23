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
    public partial class ScanLedQr : Form
    {
        public string nc12 = "";
        public string id = "";
        public string fullQrText = "";
        public bool printLabel = false;
        public ScanLedQr()
        {
            InitializeComponent();
        }

        private void ScanLedQr_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            printLabel = checkBox1.Checked;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                string[] split = textBox1.Text.Split(new string[] { "|ID:" }, StringSplitOptions.None);
                if (split.Length == 2)
                {
                    id = split[1];
                    nc12 = split[0];
                    fullQrText = textBox1.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }
    }
}
