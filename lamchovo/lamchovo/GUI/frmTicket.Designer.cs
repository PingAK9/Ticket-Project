namespace lamchovo.GUI
{
    partial class frmTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.btnImport = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTypet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridcbClient = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDayOn = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFile = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaFilter = new System.Windows.Forms.Button();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkClientExport = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbFileFilter = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCountTotal = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPriceTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(169, 227);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 25);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(204, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 27);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(111, 202);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 27);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Sữa";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(18, 202);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 27);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridView);
            this.groupBox2.Location = new System.Drawing.Point(10, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 454);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách vé";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvTenSach,
            this.dgvTacGia,
            this.dgvGiaBan,
            this.gridTypet,
            this.gridcbClient,
            this.dateOn,
            this.gridFilet});
            this.gridView.Location = new System.Drawing.Point(6, 19);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(527, 429);
            this.gridView.TabIndex = 10;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.DataPropertyName = "ID";
            this.dgvMaSach.HeaderText = "ID";
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.ReadOnly = true;
            this.dgvMaSach.Width = 50;
            // 
            // dgvTenSach
            // 
            this.dgvTenSach.DataPropertyName = "dayt";
            this.dgvTenSach.HeaderText = "Ngày";
            this.dgvTenSach.Name = "dgvTenSach";
            this.dgvTenSach.ReadOnly = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.DataPropertyName = "countt";
            this.dgvTacGia.HeaderText = "SL";
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.Width = 60;
            // 
            // dgvGiaBan
            // 
            this.dgvGiaBan.DataPropertyName = "pricet";
            this.dgvGiaBan.HeaderText = "Giá Tiền";
            this.dgvGiaBan.Name = "dgvGiaBan";
            this.dgvGiaBan.ReadOnly = true;
            // 
            // gridTypet
            // 
            this.gridTypet.DataPropertyName = "typet";
            this.gridTypet.HeaderText = "Loại vé";
            this.gridTypet.Name = "gridTypet";
            this.gridTypet.ReadOnly = true;
            this.gridTypet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTypet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gridcbClient
            // 
            this.gridcbClient.DataPropertyName = "clientt";
            this.gridcbClient.HeaderText = "Khách Hàng";
            this.gridcbClient.Name = "gridcbClient";
            this.gridcbClient.ReadOnly = true;
            this.gridcbClient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcbClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridcbClient.Width = 150;
            // 
            // dateOn
            // 
            this.dateOn.DataPropertyName = "dayont";
            this.dateOn.HeaderText = "Ngày Nộp";
            this.dateOn.Name = "dateOn";
            this.dateOn.ReadOnly = true;
            this.dateOn.Width = 90;
            // 
            // gridFilet
            // 
            this.gridFilet.DataPropertyName = "filet";
            this.gridFilet.HeaderText = "File Import";
            this.gridFilet.Name = "gridFilet";
            this.gridFilet.ReadOnly = true;
            this.gridFilet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFilet.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.dtDayOn);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbFile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbPrice);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Location = new System.Drawing.Point(556, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 241);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Loại vé:";
            // 
            // dtDayOn
            // 
            this.dtDayOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDayOn.Location = new System.Drawing.Point(166, 82);
            this.dtDayOn.Name = "dtDayOn";
            this.dtDayOn.Size = new System.Drawing.Size(123, 20);
            this.dtDayOn.TabIndex = 33;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(166, 39);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(123, 21);
            this.cbType.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ngày nhận:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "file nhập:";
            // 
            // cbFile
            // 
            this.cbFile.FormattingEnabled = true;
            this.cbFile.Location = new System.Drawing.Point(166, 123);
            this.cbFile.Name = "cbFile";
            this.cbFile.Size = new System.Drawing.Size(123, 21);
            this.cbFile.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "KH:";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(166, 166);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(123, 21);
            this.cbClient.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giá tiền:";
            // 
            // cbPrice
            // 
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(16, 166);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(123, 21);
            this.cbPrice.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // dtDay
            // 
            this.dtDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDay.Location = new System.Drawing.Point(16, 82);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(123, 20);
            this.dtDay.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(16, 124);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(123, 20);
            this.txtCount.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.dtFrom);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnXoaFilter);
            this.groupBox4.Controls.Add(this.cbTypeFilter);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.checkClientExport);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbFilter);
            this.groupBox4.Controls.Add(this.lblTo);
            this.groupBox4.Controls.Add(this.btnImport);
            this.groupBox4.Controls.Add(this.cbFileFilter);
            this.groupBox4.Controls.Add(this.lblFrom);
            this.groupBox4.Controls.Add(this.dtTo);
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Location = new System.Drawing.Point(556, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 265);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(169, 86);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(121, 20);
            this.dtFrom.TabIndex = 16;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Loại vé:";
            // 
            // btnXoaFilter
            // 
            this.btnXoaFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaFilter.BackgroundImage")));
            this.btnXoaFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaFilter.ForeColor = System.Drawing.Color.White;
            this.btnXoaFilter.Location = new System.Drawing.Point(169, 160);
            this.btnXoaFilter.Name = "btnXoaFilter";
            this.btnXoaFilter.Size = new System.Drawing.Size(120, 27);
            this.btnXoaFilter.TabIndex = 30;
            this.btnXoaFilter.Text = "Xóa";
            this.btnXoaFilter.UseVisualStyleBackColor = true;
            this.btnXoaFilter.Click += new System.EventHandler(this.btnXoaFilter_Click);
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Location = new System.Drawing.Point(169, 37);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(121, 21);
            this.cbTypeFilter.TabIndex = 36;
            this.cbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbTypeFilter_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Lọc theo:";
            // 
            // checkClientExport
            // 
            this.checkClientExport.FormattingEnabled = true;
            this.checkClientExport.Location = new System.Drawing.Point(16, 75);
            this.checkClientExport.Name = "checkClientExport";
            this.checkClientExport.Size = new System.Drawing.Size(137, 184);
            this.checkClientExport.TabIndex = 27;
            this.checkClientExport.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkClientExport_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "[Tên file][sheet]:";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Tên file nhập",
            "Ngày nhận thưởng",
            "Ngày nộp vé"});
            this.cbFilter.Location = new System.Drawing.Point(16, 37);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(123, 21);
            this.cbFilter.TabIndex = 28;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(169, 114);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 13);
            this.lblTo.TabIndex = 26;
            this.lblTo.Text = "Đến:";
            // 
            // cbFileFilter
            // 
            this.cbFileFilter.FormattingEnabled = true;
            this.cbFileFilter.Location = new System.Drawing.Point(16, 95);
            this.cbFileFilter.Name = "cbFileFilter";
            this.cbFileFilter.Size = new System.Drawing.Size(273, 21);
            this.cbFileFilter.TabIndex = 25;
            this.cbFileFilter.SelectedIndexChanged += new System.EventHandler(this.cbFileFilter_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(169, 70);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(23, 13);
            this.lblFrom.TabIndex = 25;
            this.lblFrom.Text = "Từ:";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(169, 131);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(121, 20);
            this.dtTo.TabIndex = 10;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(169, 193);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 27);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Số lượng/ Giá trị";
            // 
            // txtCountTotal
            // 
            this.txtCountTotal.Location = new System.Drawing.Point(182, 19);
            this.txtCountTotal.Name = "txtCountTotal";
            this.txtCountTotal.ReadOnly = true;
            this.txtCountTotal.Size = new System.Drawing.Size(131, 20);
            this.txtCountTotal.TabIndex = 30;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPriceTotal);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtCountTotal);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(10, 492);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(539, 50);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TỔNG HẾT";
            // 
            // txtPriceTotal
            // 
            this.txtPriceTotal.Location = new System.Drawing.Point(372, 19);
            this.txtPriceTotal.Name = "txtPriceTotal";
            this.txtPriceTotal.ReadOnly = true;
            this.txtPriceTotal.Size = new System.Drawing.Size(131, 20);
            this.txtPriceTotal.TabIndex = 32;
            this.txtPriceTotal.TextChanged += new System.EventHandler(this.txtPriceTotal_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.fileNhậpToolStripMenuItem,
            this.giáVéToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.loạiVéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaHếtToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // xóaHếtToolStripMenuItem
            // 
            this.xóaHếtToolStripMenuItem.Name = "xóaHếtToolStripMenuItem";
            this.xóaHếtToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.xóaHếtToolStripMenuItem.Text = "Xóa hết";
            this.xóaHếtToolStripMenuItem.Click += new System.EventHandler(this.xóaHếtToolStripMenuItem_Click);
            // 
            // fileNhậpToolStripMenuItem
            // 
            this.fileNhậpToolStripMenuItem.Name = "fileNhậpToolStripMenuItem";
            this.fileNhậpToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileNhậpToolStripMenuItem.Text = "File nhập";
            this.fileNhậpToolStripMenuItem.Click += new System.EventHandler(this.fileNhậpToolStripMenuItem_Click);
            // 
            // giáVéToolStripMenuItem
            // 
            this.giáVéToolStripMenuItem.Name = "giáVéToolStripMenuItem";
            this.giáVéToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.giáVéToolStripMenuItem.Text = "Giá vé";
            this.giáVéToolStripMenuItem.Click += new System.EventHandler(this.giáVéToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // loạiVéToolStripMenuItem
            // 
            this.loạiVéToolStripMenuItem.Name = "loạiVéToolStripMenuItem";
            this.loạiVéToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.loạiVéToolStripMenuItem.Text = "Loại vé";
            this.loạiVéToolStripMenuItem.Click += new System.EventHandler(this.loạiVéToolStripMenuItem_Click);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 550);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFileFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCountTotal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPriceTotal;
        private System.Windows.Forms.DateTimePicker dtDayOn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox checkClientExport;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnXoaFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridTypet;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridcbClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridFilet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiVéToolStripMenuItem;
    }
}