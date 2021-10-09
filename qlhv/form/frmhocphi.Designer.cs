namespace qlhv.form
{
    partial class frmhocphi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhocphi));
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rddadong = new System.Windows.Forms.RadioButton();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnuhy = new System.Windows.Forms.Button();
            this.lbsohocvien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdchuadong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimkiemten = new System.Windows.Forms.TextBox();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttkid = new System.Windows.Forms.TextBox();
            this.chkid = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbmahocvien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblns = new System.Windows.Forms.Label();
            this.lblidlop = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenhv = new System.Windows.Forms.Label();
            this.qlhvDataSet5 = new qlhv.qlhvDataSet5();
            this.qlhvDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlhvDataSet5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.money = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Học phí học viên\r\n";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column8});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(260, 33);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(396, 451);
            this.dgv.TabIndex = 105;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHV";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Mã học viên";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHV";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Tên học viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.HeaderText = "SDT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Malop";
            this.Column8.HeaderText = "Mã lớp";
            this.Column8.MinimumWidth = 40;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // rddadong
            // 
            this.rddadong.AutoSize = true;
            this.rddadong.Location = new System.Drawing.Point(6, 148);
            this.rddadong.Name = "rddadong";
            this.rddadong.Size = new System.Drawing.Size(70, 17);
            this.rddadong.TabIndex = 106;
            this.rddadong.TabStop = true;
            this.rddadong.Text = "Đã đóng ";
            this.rddadong.UseVisualStyleBackColor = true;
            // 
            // btnloc
            // 
            this.btnloc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnloc.BackColor = System.Drawing.Color.Silver;
            this.btnloc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnloc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.Image")));
            this.btnloc.Location = new System.Drawing.Point(75, 183);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(65, 29);
            this.btnloc.TabIndex = 107;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnloc.UseVisualStyleBackColor = false;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnuhy
            // 
            this.btnuhy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnuhy.BackColor = System.Drawing.Color.Silver;
            this.btnuhy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnuhy.FlatAppearance.BorderSize = 0;
            this.btnuhy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnuhy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnuhy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuhy.Image = ((System.Drawing.Image)(resources.GetObject("btnuhy.Image")));
            this.btnuhy.Location = new System.Drawing.Point(146, 183);
            this.btnuhy.Name = "btnuhy";
            this.btnuhy.Size = new System.Drawing.Size(68, 29);
            this.btnuhy.TabIndex = 108;
            this.btnuhy.Text = "Hủy ";
            this.btnuhy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnuhy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuhy.UseVisualStyleBackColor = false;
            this.btnuhy.Click += new System.EventHandler(this.btnuhy_Click);
            // 
            // lbsohocvien
            // 
            this.lbsohocvien.AutoSize = true;
            this.lbsohocvien.Location = new System.Drawing.Point(257, 493);
            this.lbsohocvien.Name = "lbsohocvien";
            this.lbsohocvien.Size = new System.Drawing.Size(76, 13);
            this.lbsohocvien.TabIndex = 109;
            this.lbsohocvien.Text = "Số học viên: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdchuadong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttimkiemten);
            this.groupBox1.Controls.Add(this.chkTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttkid);
            this.groupBox1.Controls.Add(this.chkid);
            this.groupBox1.Controls.Add(this.rddadong);
            this.groupBox1.Controls.Add(this.btnuhy);
            this.groupBox1.Controls.Add(this.btnloc);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 223);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdchuadong
            // 
            this.rdchuadong.AutoSize = true;
            this.rdchuadong.Location = new System.Drawing.Point(86, 148);
            this.rdchuadong.Name = "rdchuadong";
            this.rdchuadong.Size = new System.Drawing.Size(78, 17);
            this.rdchuadong.TabIndex = 112;
            this.rdchuadong.TabStop = true;
            this.rdchuadong.Text = "Chưa đóng";
            this.rdchuadong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Tên học viên:";
            // 
            // txttimkiemten
            // 
            this.txttimkiemten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiemten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemten.Location = new System.Drawing.Point(86, 112);
            this.txttimkiemten.Name = "txttimkiemten";
            this.txttimkiemten.Size = new System.Drawing.Size(139, 22);
            this.txttimkiemten.TabIndex = 115;
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTen.Location = new System.Drawing.Point(6, 86);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(69, 17);
            this.chkTen.TabIndex = 114;
            this.chkTen.Text = "Theo tên";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Mã học viên:";
            // 
            // txttkid
            // 
            this.txttkid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttkid.Location = new System.Drawing.Point(86, 55);
            this.txttkid.Name = "txttkid";
            this.txttkid.Size = new System.Drawing.Size(55, 22);
            this.txttkid.TabIndex = 112;
            // 
            // chkid
            // 
            this.chkid.AutoSize = true;
            this.chkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkid.Location = new System.Drawing.Point(6, 28);
            this.chkid.Name = "chkid";
            this.chkid.Size = new System.Drawing.Size(79, 17);
            this.chkid.TabIndex = 111;
            this.chkid.Text = "Theo mã id";
            this.chkid.UseVisualStyleBackColor = true;
            this.chkid.CheckedChanged += new System.EventHandler(this.chkid_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.money);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbmahocvien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblConNo);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lblSdt);
            this.groupBox2.Controls.Add(this.lblns);
            this.groupBox2.Controls.Add(this.lblidlop);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTenhv);
            this.groupBox2.Location = new System.Drawing.Point(16, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 220);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lbmahocvien
            // 
            this.lbmahocvien.AutoSize = true;
            this.lbmahocvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahocvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lbmahocvien.Location = new System.Drawing.Point(83, 27);
            this.lbmahocvien.Name = "lbmahocvien";
            this.lbmahocvien.Size = new System.Drawing.Size(27, 13);
            this.lbmahocvien.TabIndex = 68;
            this.lbmahocvien.Text = "<id>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mã học viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tên học viên:";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConNo.ForeColor = System.Drawing.Color.Red;
            this.lblConNo.Location = new System.Drawing.Point(86, 182);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(46, 13);
            this.lblConNo.TabIndex = 65;
            this.lblConNo.Text = "<count>";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label22.Location = new System.Drawing.Point(11, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 64;
            this.label22.Text = "Còn nợ:";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblSdt.Location = new System.Drawing.Point(83, 119);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(33, 13);
            this.lblSdt.TabIndex = 61;
            this.lblSdt.Text = "<sdt>";
            // 
            // lblns
            // 
            this.lblns.AutoSize = true;
            this.lblns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblns.ForeColor = System.Drawing.Color.Blue;
            this.lblns.Location = new System.Drawing.Point(84, 87);
            this.lblns.Name = "lblns";
            this.lblns.Size = new System.Drawing.Size(37, 13);
            this.lblns.TabIndex = 58;
            this.lblns.Text = "<dob>";
            // 
            // lblidlop
            // 
            this.lblidlop.AutoSize = true;
            this.lblidlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidlop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblidlop.Location = new System.Drawing.Point(192, 27);
            this.lblidlop.Name = "lblidlop";
            this.lblidlop.Size = new System.Drawing.Size(27, 13);
            this.lblidlop.TabIndex = 57;
            this.lblidlop.Text = "<id>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(11, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "SDT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(11, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(143, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mã lớp:";
            // 
            // lblTenhv
            // 
            this.lblTenhv.AutoSize = true;
            this.lblTenhv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenhv.ForeColor = System.Drawing.Color.Green;
            this.lblTenhv.Location = new System.Drawing.Point(83, 57);
            this.lblTenhv.Name = "lblTenhv";
            this.lblTenhv.Size = new System.Drawing.Size(72, 13);
            this.lblTenhv.TabIndex = 51;
            this.lblTenhv.Text = "<class name>";
            // 
            // qlhvDataSet5
            // 
            this.qlhvDataSet5.DataSetName = "qlhvDataSet5";
            this.qlhvDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlhvDataSet5BindingSource
            // 
            this.qlhvDataSet5BindingSource.DataSource = this.qlhvDataSet5;
            this.qlhvDataSet5BindingSource.Position = 0;
            // 
            // qlhvDataSet5BindingSource1
            // 
            this.qlhvDataSet5BindingSource1.DataSource = this.qlhvDataSet5;
            this.qlhvDataSet5BindingSource1.Position = 0;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.money.Location = new System.Drawing.Point(85, 151);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(50, 13);
            this.money.TabIndex = 70;
            this.money.Text = "<money>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(11, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Học phí:";
            // 
            // frmhocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbsohocvien);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmhocphi";
            this.Text = "frmhocphi";
            this.Load += new System.EventHandler(this.frmhocphi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet5BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton rddadong;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnuhy;
        private System.Windows.Forms.Label lbsohocvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttkid;
        private System.Windows.Forms.CheckBox chkid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttimkiemten;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.RadioButton rdchuadong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblns;
        private System.Windows.Forms.Label lblidlop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTenhv;
        private System.Windows.Forms.Label lbmahocvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource qlhvDataSet5BindingSource;
        private qlhvDataSet5 qlhvDataSet5;
        private System.Windows.Forms.BindingSource qlhvDataSet5BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label7;
    }
}