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
    public partial class ChooseLineOrTester : Form
    {
        public int result;
        public ChooseLineOrTester(Type type, Dictionary<int, string> testerIdToName)
        {
            InitializeComponent();
            this.type = type;
            this.testerIdToName = testerIdToName;
        }

        string[] smtLines = new string[] { "SMT2", "SMT3", "SMT4" };
        private readonly Type type;
        private readonly Dictionary<int, string> testerIdToName;

        public enum Type
        {
            SmtLines,
            Testers
        }

        private void ChooseLineOrTester_Load(object sender, EventArgs e)
        {
            if(type == Type.SmtLines)
            {
                comboBox1.Items.AddRange(smtLines);
            }
            else
            {
                comboBox1.Items.AddRange(testerIdToName.Where(x => x.Key > 0).Select(x => x.Value).OrderByDescending(x => x).ToArray());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Length > 0)
            {
                if (type == Type.SmtLines)
                {
                    result = int.Parse(comboBox1.SelectedItem.ToString().Replace("SMT",""));
                }
                else
                {
                    result = testerIdToName.Where(x => x.Value == comboBox1.SelectedItem.ToString()).Select(x => x.Key).First();
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
