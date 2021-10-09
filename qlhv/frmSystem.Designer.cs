namespace qlhv
{
    partial class frmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelquantri = new System.Windows.Forms.Panel();
            this.btnbchvdcc = new System.Windows.Forms.Button();
            this.btntkhvnohp = new System.Windows.Forms.Button();
            this.btnquantri = new System.Windows.Forms.Button();
            this.panelhocvien = new System.Windows.Forms.Panel();
            this.btndiem = new System.Windows.Forms.Button();
            this.btnhocphi = new System.Windows.Forms.Button();
            this.btnqlhv = new System.Windows.Forms.Button();
            this.btntnhv = new System.Windows.Forms.Button();
            this.btnhocvien = new System.Windows.Forms.Button();
            this.panellop = new System.Windows.Forms.Panel();
            this.btngiaovien = new System.Windows.Forms.Button();
            this.btnlop = new System.Windows.Forms.Button();
            this.btnlopgiaovien = new System.Windows.Forms.Button();
            this.btnqlnhanvien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelform = new System.Windows.Forms.Panel();
            this.background1 = new qlhv.background();
            this.panel1.SuspendLayout();
            this.panelquantri.SuspendLayout();
            this.panelhocvien.SuspendLayout();
            this.panellop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelform.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(210)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panelquantri);
            this.panel1.Controls.Add(this.btnquantri);
            this.panel1.Controls.Add(this.panelhocvien);
            this.panel1.Controls.Add(this.btnhocvien);
            this.panel1.Controls.Add(this.panellop);
            this.panel1.Controls.Add(this.btnlopgiaovien);
            this.panel1.Controls.Add(this.btnqlnhanvien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 552);
            this.panel1.TabIndex = 0;
            // 
            // panelquantri
            // 
            this.panelquantri.Controls.Add(this.btnbchvdcc);
            this.panelquantri.Controls.Add(this.btntkhvnohp);
            this.panelquantri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelquantri.Location = new System.Drawing.Point(0, 541);
            this.panelquantri.Name = "panelquantri";
            this.panelquantri.Size = new System.Drawing.Size(231, 73);
            this.panelquantri.TabIndex = 13;
            // 
            // btnbchvdcc
            // 
            this.btnbchvdcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btnbchvdcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbchvdcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbchvdcc.FlatAppearance.BorderSize = 0;
            this.btnbchvdcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbchvdcc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnbchvdcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbchvdcc.Location = new System.Drawing.Point(0, 34);
            this.btnbchvdcc.Margin = new System.Windows.Forms.Padding(0);
            this.btnbchvdcc.Name = "btnbchvdcc";
            this.btnbchvdcc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnbchvdcc.Size = new System.Drawing.Size(231, 34);
            this.btnbchvdcc.TabIndex = 7;
            this.btnbchvdcc.Text = "Báo cáo học viên đạt chứng chỉ";
            this.btnbchvdcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbchvdcc.UseVisualStyleBackColor = false;
            this.btnbchvdcc.Click += new System.EventHandler(this.btntiepnhanhocvien_Click);
            // 
            // btntkhvnohp
            // 
            this.btntkhvnohp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btntkhvnohp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntkhvnohp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntkhvnohp.FlatAppearance.BorderSize = 0;
            this.btntkhvnohp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntkhvnohp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btntkhvnohp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntkhvnohp.Location = new System.Drawing.Point(0, 0);
            this.btntkhvnohp.Margin = new System.Windows.Forms.Padding(0);
            this.btntkhvnohp.Name = "btntkhvnohp";
            this.btntkhvnohp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btntkhvnohp.Size = new System.Drawing.Size(231, 34);
            this.btntkhvnohp.TabIndex = 6;
            this.btntkhvnohp.Text = "Thống kê học viên nợ học phí";
            this.btntkhvnohp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntkhvnohp.UseVisualStyleBackColor = false;
            this.btntkhvnohp.Click += new System.EventHandler(this.btnbaocaothongke_Click);
            // 
            // btnquantri
            // 
            this.btnquantri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquantri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnquantri.FlatAppearance.BorderSize = 0;
            this.btnquantri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquantri.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnquantri.Image = ((System.Drawing.Image)(resources.GetObject("btnquantri.Image")));
            this.btnquantri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquantri.Location = new System.Drawing.Point(0, 500);
            this.btnquantri.Name = "btnquantri";
            this.btnquantri.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnquantri.Size = new System.Drawing.Size(231, 41);
            this.btnquantri.TabIndex = 12;
            this.btnquantri.Text = "      Thống kê";
            this.btnquantri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquantri.UseVisualStyleBackColor = true;
            this.btnquantri.Click += new System.EventHandler(this.btnquantri_Click);
            // 
            // panelhocvien
            // 
            this.panelhocvien.Controls.Add(this.btndiem);
            this.panelhocvien.Controls.Add(this.btnhocphi);
            this.panelhocvien.Controls.Add(this.btnqlhv);
            this.panelhocvien.Controls.Add(this.btntnhv);
            this.panelhocvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhocvien.Location = new System.Drawing.Point(0, 357);
            this.panelhocvien.Name = "panelhocvien";
            this.panelhocvien.Size = new System.Drawing.Size(231, 143);
            this.panelhocvien.TabIndex = 12;
            // 
            // btndiem
            // 
            this.btndiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btndiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndiem.FlatAppearance.BorderSize = 0;
            this.btndiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btndiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndiem.Location = new System.Drawing.Point(0, 102);
            this.btndiem.Margin = new System.Windows.Forms.Padding(0);
            this.btndiem.Name = "btndiem";
            this.btndiem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btndiem.Size = new System.Drawing.Size(231, 34);
            this.btndiem.TabIndex = 9;
            this.btndiem.Text = "Bảng điểm";
            this.btndiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndiem.UseVisualStyleBackColor = false;
            this.btndiem.Click += new System.EventHandler(this.btndiem_Click);
            // 
            // btnhocphi
            // 
            this.btnhocphi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btnhocphi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhocphi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhocphi.FlatAppearance.BorderSize = 0;
            this.btnhocphi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhocphi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnhocphi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhocphi.Location = new System.Drawing.Point(0, 68);
            this.btnhocphi.Margin = new System.Windows.Forms.Padding(0);
            this.btnhocphi.Name = "btnhocphi";
            this.btnhocphi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnhocphi.Size = new System.Drawing.Size(231, 34);
            this.btnhocphi.TabIndex = 8;
            this.btnhocphi.Text = "Học phí";
            this.btnhocphi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhocphi.UseVisualStyleBackColor = false;
            this.btnhocphi.Click += new System.EventHandler(this.btnbangdiem_Click);
            // 
            // btnqlhv
            // 
            this.btnqlhv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btnqlhv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqlhv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqlhv.FlatAppearance.BorderSize = 0;
            this.btnqlhv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqlhv.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnqlhv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlhv.Location = new System.Drawing.Point(0, 34);
            this.btnqlhv.Margin = new System.Windows.Forms.Padding(0);
            this.btnqlhv.Name = "btnqlhv";
            this.btnqlhv.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnqlhv.Size = new System.Drawing.Size(231, 34);
            this.btnqlhv.TabIndex = 7;
            this.btnqlhv.Text = "Quản lý học viên";
            this.btnqlhv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlhv.UseVisualStyleBackColor = false;
            this.btnqlhv.Click += new System.EventHandler(this.btnhocphi_Click);
            // 
            // btntnhv
            // 
            this.btntnhv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btntnhv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntnhv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntnhv.FlatAppearance.BorderSize = 0;
            this.btntnhv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntnhv.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btntnhv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntnhv.Location = new System.Drawing.Point(0, 0);
            this.btntnhv.Margin = new System.Windows.Forms.Padding(0);
            this.btntnhv.Name = "btntnhv";
            this.btntnhv.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btntnhv.Size = new System.Drawing.Size(231, 34);
            this.btntnhv.TabIndex = 6;
            this.btntnhv.Text = "Tiếp nhận học viên";
            this.btntnhv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntnhv.UseVisualStyleBackColor = false;
            this.btntnhv.Click += new System.EventHandler(this.btnqlhocvien_Click);
            // 
            // btnhocvien
            // 
            this.btnhocvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhocvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhocvien.FlatAppearance.BorderSize = 0;
            this.btnhocvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhocvien.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnhocvien.Image = ((System.Drawing.Image)(resources.GetObject("btnhocvien.Image")));
            this.btnhocvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhocvien.Location = new System.Drawing.Point(0, 316);
            this.btnhocvien.Name = "btnhocvien";
            this.btnhocvien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnhocvien.Size = new System.Drawing.Size(231, 41);
            this.btnhocvien.TabIndex = 11;
            this.btnhocvien.Text = "      Học viên";
            this.btnhocvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhocvien.UseVisualStyleBackColor = true;
            this.btnhocvien.Click += new System.EventHandler(this.btnhocvien_Click);
            // 
            // panellop
            // 
            this.panellop.Controls.Add(this.btngiaovien);
            this.panellop.Controls.Add(this.btnlop);
            this.panellop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellop.Location = new System.Drawing.Point(0, 242);
            this.panellop.Name = "panellop";
            this.panellop.Size = new System.Drawing.Size(231, 74);
            this.panellop.TabIndex = 10;
            // 
            // btngiaovien
            // 
            this.btngiaovien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btngiaovien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiaovien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngiaovien.FlatAppearance.BorderSize = 0;
            this.btngiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiaovien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btngiaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiaovien.Location = new System.Drawing.Point(0, 34);
            this.btngiaovien.Margin = new System.Windows.Forms.Padding(0);
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btngiaovien.Size = new System.Drawing.Size(231, 34);
            this.btngiaovien.TabIndex = 7;
            this.btngiaovien.Text = "Quản lý giáo viên";
            this.btngiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiaovien.UseVisualStyleBackColor = false;
            this.btngiaovien.Click += new System.EventHandler(this.btngiaovien_Click);
            // 
            // btnlop
            // 
            this.btnlop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(219)))), ((int)(((byte)(147)))));
            this.btnlop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlop.FlatAppearance.BorderSize = 0;
            this.btnlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlop.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnlop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlop.Location = new System.Drawing.Point(0, 0);
            this.btnlop.Margin = new System.Windows.Forms.Padding(0);
            this.btnlop.Name = "btnlop";
            this.btnlop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnlop.Size = new System.Drawing.Size(231, 34);
            this.btnlop.TabIndex = 6;
            this.btnlop.Text = "Quản lý lớp";
            this.btnlop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlop.UseVisualStyleBackColor = false;
            this.btnlop.Click += new System.EventHandler(this.btnlop_Click);
            // 
            // btnlopgiaovien
            // 
            this.btnlopgiaovien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlopgiaovien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlopgiaovien.FlatAppearance.BorderSize = 0;
            this.btnlopgiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlopgiaovien.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnlopgiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnlopgiaovien.Image")));
            this.btnlopgiaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlopgiaovien.Location = new System.Drawing.Point(0, 201);
            this.btnlopgiaovien.Name = "btnlopgiaovien";
            this.btnlopgiaovien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnlopgiaovien.Size = new System.Drawing.Size(231, 41);
            this.btnlopgiaovien.TabIndex = 9;
            this.btnlopgiaovien.Text = "      Lớp - Giáo viên";
            this.btnlopgiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlopgiaovien.UseVisualStyleBackColor = true;
            this.btnlopgiaovien.Click += new System.EventHandler(this.btnlopgiaovien_Click);
            // 
            // btnqlnhanvien
            // 
            this.btnqlnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqlnhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqlnhanvien.FlatAppearance.BorderSize = 0;
            this.btnqlnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqlnhanvien.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnqlnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnqlnhanvien.Image")));
            this.btnqlnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlnhanvien.Location = new System.Drawing.Point(0, 160);
            this.btnqlnhanvien.Name = "btnqlnhanvien";
            this.btnqlnhanvien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnqlnhanvien.Size = new System.Drawing.Size(231, 41);
            this.btnqlnhanvien.TabIndex = 7;
            this.btnqlnhanvien.Text = "      Quản lý nhân viên";
            this.btnqlnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlnhanvien.UseVisualStyleBackColor = true;
            this.btnqlnhanvien.Click += new System.EventHandler(this.btnqlnhanvien_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(201)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lbusername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 160);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(210, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(210)))), ((int)(((byte)(122)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 41);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hệ thống";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 33);
            this.button7.TabIndex = 9;
            this.button7.Text = "     Đăng xuất";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "     Đổi mật khẩu";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lbusername.Location = new System.Drawing.Point(114, 25);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(70, 17);
            this.lbusername.TabIndex = 8;
            this.lbusername.Text = "{username}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin chào";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "@peo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(231, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 30);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "@Lưu Văn Quân - D13CNPM1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(648, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelform
            // 
            this.panelform.Controls.Add(this.background1);
            this.panelform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelform.Location = new System.Drawing.Point(231, 30);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(677, 522);
            this.panelform.TabIndex = 2;
            // 
            // background1
            // 
            this.background1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.background1.Location = new System.Drawing.Point(0, 0);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(677, 519);
            this.background1.TabIndex = 0;
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(908, 552);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panelquantri.ResumeLayout(false);
            this.panelhocvien.ResumeLayout(false);
            this.panellop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnqlnhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelquantri;
        private System.Windows.Forms.Button btnbchvdcc;
        private System.Windows.Forms.Button btntkhvnohp;
        private System.Windows.Forms.Button btnquantri;
        private System.Windows.Forms.Panel panelhocvien;
        private System.Windows.Forms.Button btnhocphi;
        private System.Windows.Forms.Button btnqlhv;
        private System.Windows.Forms.Button btntnhv;
        private System.Windows.Forms.Button btnhocvien;
        private System.Windows.Forms.Panel panellop;
        private System.Windows.Forms.Button btngiaovien;
        private System.Windows.Forms.Button btnlop;
        private System.Windows.Forms.Button btnlopgiaovien;
        private System.Windows.Forms.Panel panelform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btndiem;
        private background background1;
    }
}