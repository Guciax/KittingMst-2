using BrightIdeasSoftware;

namespace KittingMst_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.ColOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductionQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNewOnly = new System.Windows.Forms.CheckBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.cbHideFinished = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bKT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvLedUsedForOrder = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lvSelectedOrder = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Akcja = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLedLoad = new System.Windows.Forms.PictureBox();
            this.bAddLeds = new System.Windows.Forms.Button();
            this.bLoadLeds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeProductStructure = new BrightIdeasSoftware.TreeListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lvLedsSummary = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadingTransitionTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvLedUsedForOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSelectedOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLedLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeProductStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvLedsSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1891, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvOrdersList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 1055);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.AllowUserToResizeColumns = false;
            this.dgvOrdersList.AllowUserToResizeRows = false;
            this.dgvOrdersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderNo,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.ColProductionQty});
            this.dgvOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersList.Location = new System.Drawing.Point(1, 56);
            this.dgvOrdersList.Margin = new System.Windows.Forms.Padding(1);
            this.dgvOrdersList.MultiSelect = false;
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.ReadOnly = true;
            this.dgvOrdersList.RowHeadersVisible = false;
            this.dgvOrdersList.RowHeadersWidth = 51;
            this.dgvOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersList.Size = new System.Drawing.Size(798, 998);
            this.dgvOrdersList.TabIndex = 1;
            this.dgvOrdersList.SelectionChanged += new System.EventHandler(this.dgvOrdersList_SelectionChanged);
            // 
            // ColOrderNo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColOrderNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColOrderNo.HeaderText = "Numer";
            this.ColOrderNo.MinimumWidth = 6;
            this.ColOrderNo.Name = "ColOrderNo";
            this.ColOrderNo.ReadOnly = true;
            this.ColOrderNo.Width = 125;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "0000\" \"000\" \"000";
            dataGridViewCellStyle2.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "10NC";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Start";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "-";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Koniec";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "-";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "Plan wysyłki";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Ilość wysyłki";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // ColProductionQty
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColProductionQty.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColProductionQty.HeaderText = "Ilość produkcji";
            this.ColProductionQty.MinimumWidth = 6;
            this.ColProductionQty.Name = "ColProductionQty";
            this.ColProductionQty.ReadOnly = true;
            this.ColProductionQty.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.cbNewOnly);
            this.panel1.Controls.Add(this.pbRefresh);
            this.panel1.Controls.Add(this.bRefresh);
            this.panel1.Controls.Add(this.cbHideFinished);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(798, 53);
            this.panel1.TabIndex = 2;
            // 
            // cbNewOnly
            // 
            this.cbNewOnly.AutoSize = true;
            this.cbNewOnly.Checked = true;
            this.cbNewOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNewOnly.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbNewOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNewOnly.ForeColor = System.Drawing.Color.White;
            this.cbNewOnly.Location = new System.Drawing.Point(167, 6);
            this.cbNewOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNewOnly.Name = "cbNewOnly";
            this.cbNewOnly.Size = new System.Drawing.Size(158, 41);
            this.cbNewOnly.TabIndex = 4;
            this.cbNewOnly.Text = "pokaż tylko nowe";
            this.cbNewOnly.UseVisualStyleBackColor = true;
            this.cbNewOnly.CheckedChanged += new System.EventHandler(this.cbNewOnly_CheckedChanged);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRefresh.Image = global::KittingMst_2.Properties.Resources.spinner30x30;
            this.pbRefresh.InitialImage = global::KittingMst_2.Properties.Resources.spinner30x30;
            this.pbRefresh.Location = new System.Drawing.Point(595, 6);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(60, 41);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 3;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Visible = false;
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRefresh.ForeColor = System.Drawing.Color.White;
            this.bRefresh.Location = new System.Drawing.Point(655, 6);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(136, 41);
            this.bRefresh.TabIndex = 2;
            this.bRefresh.Text = "Odśwież";
            this.bRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // cbHideFinished
            // 
            this.cbHideFinished.AutoSize = true;
            this.cbHideFinished.Checked = true;
            this.cbHideFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideFinished.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbHideFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbHideFinished.ForeColor = System.Drawing.Color.White;
            this.cbHideFinished.Location = new System.Drawing.Point(7, 6);
            this.cbHideFinished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHideFinished.Name = "cbHideFinished";
            this.cbHideFinished.Size = new System.Drawing.Size(160, 41);
            this.cbHideFinished.TabIndex = 1;
            this.cbHideFinished.Text = "ukryj zakończone";
            this.cbHideFinished.UseVisualStyleBackColor = true;
            this.cbHideFinished.CheckedChanged += new System.EventHandler(this.cbHideFinished_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lvLedUsedForOrder, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lvSelectedOrder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.treeProductStructure, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lvLedsSummary, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(804, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1083, 1047);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel5.Controls.Add(this.bKT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 999);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel5.Size = new System.Drawing.Size(531, 47);
            this.panel5.TabIndex = 9;
            // 
            // bKT
            // 
            this.bKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bKT.Dock = System.Windows.Forms.DockStyle.Left;
            this.bKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKT.ForeColor = System.Drawing.Color.White;
            this.bKT.Location = new System.Drawing.Point(7, 6);
            this.bKT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bKT.Name = "bKT";
            this.bKT.Size = new System.Drawing.Size(228, 35);
            this.bKT.TabIndex = 1;
            this.bKT.Text = "Karta technologiczna";
            this.bKT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bKT.UseVisualStyleBackColor = false;
            this.bKT.Click += new System.EventHandler(this.bKT_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(534, 999);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel4.Size = new System.Drawing.Size(548, 47);
            this.panel4.TabIndex = 8;
            // 
            // lvLedUsedForOrder
            // 
            this.lvLedUsedForOrder.AllColumns.Add(this.olvColumn1);
            this.lvLedUsedForOrder.AllColumns.Add(this.olvColumn4);
            this.lvLedUsedForOrder.AllColumns.Add(this.olvColumn5);
            this.lvLedUsedForOrder.AllColumns.Add(this.olvColumn6);
            this.lvLedUsedForOrder.CellEditUseWholeCell = false;
            this.lvLedUsedForOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.lvLedUsedForOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvLedUsedForOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLedUsedForOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvLedUsedForOrder.GridLines = true;
            this.lvLedUsedForOrder.HideSelection = false;
            this.lvLedUsedForOrder.Location = new System.Drawing.Point(1, 456);
            this.lvLedUsedForOrder.Margin = new System.Windows.Forms.Padding(1);
            this.lvLedUsedForOrder.Name = "lvLedUsedForOrder";
            this.lvLedUsedForOrder.Size = new System.Drawing.Size(531, 541);
            this.lvLedUsedForOrder.TabIndex = 3;
            this.lvLedUsedForOrder.UseCellFormatEvents = true;
            this.lvLedUsedForOrder.UseCompatibleStateImageBehavior = false;
            this.lvLedUsedForOrder.UseHyperlinks = true;
            this.lvLedUsedForOrder.View = System.Windows.Forms.View.Details;
            this.lvLedUsedForOrder.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.lvLedUsedForOrder_ButtonClick);
            this.lvLedUsedForOrder.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.lvLedUsedForOrder_FormatCell);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Nc12_Formated_Rank";
            this.olvColumn1.AspectToStringFormat = "";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "12NC";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn1.Width = 115;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Id";
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "ID";
            this.olvColumn4.Width = 75;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Quantity";
            this.olvColumn5.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn5.Text = "Ilość";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "ConnectedToOrder";
            this.olvColumn6.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn6.IsButton = true;
            this.olvColumn6.Text = "Akt. przypisane do";
            this.olvColumn6.Width = 140;
            // 
            // lvSelectedOrder
            // 
            this.lvSelectedOrder.AllColumns.Add(this.olvColumn2);
            this.lvSelectedOrder.AllColumns.Add(this.olvColumn3);
            this.lvSelectedOrder.AllColumns.Add(this.Akcja);
            this.lvSelectedOrder.CellEditUseWholeCell = false;
            this.lvSelectedOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn3,
            this.Akcja});
            this.lvSelectedOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvSelectedOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelectedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvSelectedOrder.GridLines = true;
            this.lvSelectedOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSelectedOrder.HideSelection = false;
            this.lvSelectedOrder.Location = new System.Drawing.Point(1, 1);
            this.lvSelectedOrder.Margin = new System.Windows.Forms.Padding(1);
            this.lvSelectedOrder.Name = "lvSelectedOrder";
            this.lvSelectedOrder.ShowGroups = false;
            this.lvSelectedOrder.Size = new System.Drawing.Size(531, 404);
            this.lvSelectedOrder.TabIndex = 1;
            this.lvSelectedOrder.UseCellFormatEvents = true;
            this.lvSelectedOrder.UseCompatibleStateImageBehavior = false;
            this.lvSelectedOrder.UseHyperlinks = true;
            this.lvSelectedOrder.View = System.Windows.Forms.View.Details;
            this.lvSelectedOrder.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.lvSelectedOrder_ButtonClick);
            this.lvSelectedOrder.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.lvSelectedOrder_CellClick);
            this.lvSelectedOrder.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.lvSelectedOrder_FormatCell);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "first";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Width = 150;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "second";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "";
            this.olvColumn3.Width = 150;
            // 
            // Akcja
            // 
            this.Akcja.AspectName = "edit";
            this.Akcja.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.Akcja.IsButton = true;
            this.Akcja.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.pbLedLoad);
            this.panel2.Controls.Add(this.bAddLeds);
            this.panel2.Controls.Add(this.bLoadLeds);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 407);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(531, 47);
            this.panel2.TabIndex = 4;
            // 
            // pbLedLoad
            // 
            this.pbLedLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLedLoad.Image = global::KittingMst_2.Properties.Resources.spinner30x30;
            this.pbLedLoad.Location = new System.Drawing.Point(398, 6);
            this.pbLedLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLedLoad.Name = "pbLedLoad";
            this.pbLedLoad.Size = new System.Drawing.Size(60, 35);
            this.pbLedLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLedLoad.TabIndex = 2;
            this.pbLedLoad.TabStop = false;
            this.pbLedLoad.Visible = false;
            // 
            // bAddLeds
            // 
            this.bAddLeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bAddLeds.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAddLeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddLeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddLeds.ForeColor = System.Drawing.Color.White;
            this.bAddLeds.Location = new System.Drawing.Point(262, 6);
            this.bAddLeds.Margin = new System.Windows.Forms.Padding(67, 4, 7, 4);
            this.bAddLeds.Name = "bAddLeds";
            this.bAddLeds.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bAddLeds.Size = new System.Drawing.Size(136, 35);
            this.bAddLeds.TabIndex = 3;
            this.bAddLeds.Text = "Dodaj...";
            this.bAddLeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddLeds.UseVisualStyleBackColor = false;
            this.bAddLeds.Visible = false;
            this.bAddLeds.Click += new System.EventHandler(this.bAddLeds_Click);
            // 
            // bLoadLeds
            // 
            this.bLoadLeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bLoadLeds.Dock = System.Windows.Forms.DockStyle.Left;
            this.bLoadLeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoadLeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLoadLeds.ForeColor = System.Drawing.Color.White;
            this.bLoadLeds.Location = new System.Drawing.Point(126, 6);
            this.bLoadLeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLoadLeds.Name = "bLoadLeds";
            this.bLoadLeds.Size = new System.Drawing.Size(136, 35);
            this.bLoadLeds.TabIndex = 0;
            this.bLoadLeds.Text = "Wczytaj";
            this.bLoadLeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLoadLeds.UseVisualStyleBackColor = false;
            this.bLoadLeds.Click += new System.EventHandler(this.bLoadLeds_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diody LED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeProductStructure
            // 
            this.treeProductStructure.AllColumns.Add(this.olvColumn7);
            this.treeProductStructure.AllColumns.Add(this.olvColumn9);
            this.treeProductStructure.AllColumns.Add(this.olvColumn8);
            this.treeProductStructure.CellEditUseWholeCell = false;
            this.treeProductStructure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn8});
            this.treeProductStructure.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeProductStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProductStructure.HideSelection = false;
            this.treeProductStructure.Location = new System.Drawing.Point(534, 1);
            this.treeProductStructure.Margin = new System.Windows.Forms.Padding(1);
            this.treeProductStructure.Name = "treeProductStructure";
            this.treeProductStructure.ShowGroups = false;
            this.treeProductStructure.Size = new System.Drawing.Size(548, 404);
            this.treeProductStructure.TabIndex = 5;
            this.treeProductStructure.UseCompatibleStateImageBehavior = false;
            this.treeProductStructure.View = System.Windows.Forms.View.Details;
            this.treeProductStructure.VirtualMode = true;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "nc12";
            this.olvColumn7.Text = "12NC";
            this.olvColumn7.Width = 150;
            // 
            // olvColumn9
            // 
            this.olvColumn9.DisplayIndex = 1;
            this.olvColumn9.IsVisible = false;
            this.olvColumn9.Text = "Ilość";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "name";
            this.olvColumn8.Text = "Nazwa";
            this.olvColumn8.Width = 250;
            // 
            // lvLedsSummary
            // 
            this.lvLedsSummary.AllColumns.Add(this.olvColumn10);
            this.lvLedsSummary.AllColumns.Add(this.olvColumn11);
            this.lvLedsSummary.AllColumns.Add(this.olvColumn12);
            this.lvLedsSummary.CellEditUseWholeCell = false;
            this.lvLedsSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn10,
            this.olvColumn11,
            this.olvColumn12});
            this.lvLedsSummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvLedsSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLedsSummary.GridLines = true;
            this.lvLedsSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvLedsSummary.HideSelection = false;
            this.lvLedsSummary.Location = new System.Drawing.Point(534, 456);
            this.lvLedsSummary.Margin = new System.Windows.Forms.Padding(1);
            this.lvLedsSummary.Name = "lvLedsSummary";
            this.lvLedsSummary.ShowGroups = false;
            this.lvLedsSummary.Size = new System.Drawing.Size(548, 541);
            this.lvLedsSummary.TabIndex = 6;
            this.lvLedsSummary.UseCompatibleStateImageBehavior = false;
            this.lvLedsSummary.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "first";
            this.olvColumn10.Width = 100;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "second";
            this.olvColumn11.Width = 140;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "edit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(534, 407);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 47);
            this.panel3.TabIndex = 7;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kitting MST v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvLedUsedForOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSelectedOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLedLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeProductStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvLedsSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ObjectListView lvSelectedOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbHideFinished;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private OLVColumn olvColumn2;
        private OLVColumn olvColumn3;
        private OLVColumn Akcja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLoadLeds;
        private System.Windows.Forms.Timer loadingTransitionTimer;
        private System.Windows.Forms.PictureBox pbLedLoad;
        private ObjectListView lvLedUsedForOrder;
        private OLVColumn olvColumn1;
        private OLVColumn olvColumn4;
        private OLVColumn olvColumn5;
        private OLVColumn olvColumn6;
        private TreeListView treeProductStructure;
        private OLVColumn olvColumn7;
        private OLVColumn olvColumn8;
        private OLVColumn olvColumn9;
        private System.Windows.Forms.Button bAddLeds;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.PictureBox pbRefresh;
        private ObjectListView lvLedsSummary;
        private OLVColumn olvColumn10;
        private OLVColumn olvColumn11;
        private OLVColumn olvColumn12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bKT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbNewOnly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductionQty;
    }
}

