namespace KittingMst_2.Forms
{
    partial class ChangeProductionQtyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lModelInfo = new System.Windows.Forms.Label();
            this.lMbQtyCalculation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość:";
            // 
            // lModelInfo
            // 
            this.lModelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lModelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lModelInfo.Location = new System.Drawing.Point(0, 58);
            this.lModelInfo.Name = "lModelInfo";
            this.lModelInfo.Size = new System.Drawing.Size(381, 107);
            this.lModelInfo.TabIndex = 2;
            this.lModelInfo.Text = "Model:";
            // 
            // lMbQtyCalculation
            // 
            this.lMbQtyCalculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lMbQtyCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMbQtyCalculation.Location = new System.Drawing.Point(0, 165);
            this.lMbQtyCalculation.Name = "lMbQtyCalculation";
            this.lMbQtyCalculation.Size = new System.Drawing.Size(381, 107);
            this.lMbQtyCalculation.TabIndex = 3;
            this.lMbQtyCalculation.Text = "Ilość MB:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ChangeProductionQtyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lMbQtyCalculation);
            this.Controls.Add(this.lModelInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChangeProductionQtyForm";
            this.Text = "Zmiana ilości";
            this.Load += new System.EventHandler(this.ChangeProductionQtyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lModelInfo;
        private System.Windows.Forms.Label lMbQtyCalculation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}