namespace KittingMst_2.Forms
{
    partial class EditConnectedOrder
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
            this.cbOrderNumber = new System.Windows.Forms.ComboBox();
            this.lOrderInfo = new System.Windows.Forms.Label();
            this.nudPcbOnMbCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPcbOnMbCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer zlecenia powiązanego:";
            // 
            // cbOrderNumber
            // 
            this.cbOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbOrderNumber.FormattingEnabled = true;
            this.cbOrderNumber.Location = new System.Drawing.Point(12, 30);
            this.cbOrderNumber.Name = "cbOrderNumber";
            this.cbOrderNumber.Size = new System.Drawing.Size(254, 28);
            this.cbOrderNumber.TabIndex = 1;
            this.cbOrderNumber.SelectedIndexChanged += new System.EventHandler(this.cbOrderNumber_SelectedIndexChanged);
            // 
            // lOrderInfo
            // 
            this.lOrderInfo.AutoSize = true;
            this.lOrderInfo.Location = new System.Drawing.Point(12, 71);
            this.lOrderInfo.Name = "lOrderInfo";
            this.lOrderInfo.Size = new System.Drawing.Size(16, 13);
            this.lOrderInfo.TabIndex = 2;
            this.lOrderInfo.Text = "...";
            // 
            // nudPcbOnMbCount
            // 
            this.nudPcbOnMbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudPcbOnMbCount.Location = new System.Drawing.Point(15, 190);
            this.nudPcbOnMbCount.Name = "nudPcbOnMbCount";
            this.nudPcbOnMbCount.Size = new System.Drawing.Size(120, 26);
            this.nudPcbOnMbCount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(152, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Wyczyść zlecenie powiązane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 53);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // EditConnectedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nudPcbOnMbCount);
            this.Controls.Add(this.lOrderInfo);
            this.Controls.Add(this.cbOrderNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditConnectedOrder";
            this.Text = "Zlecenie powiązane";
            this.Load += new System.EventHandler(this.EditConnectedOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPcbOnMbCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrderNumber;
        private System.Windows.Forms.Label lOrderInfo;
        private System.Windows.Forms.NumericUpDown nudPcbOnMbCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}