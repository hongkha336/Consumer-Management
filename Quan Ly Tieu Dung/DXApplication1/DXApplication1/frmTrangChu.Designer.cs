namespace DXApplication1
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.lbTen = new System.Windows.Forms.Label();
            this.Namesss = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ngays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.lbTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.lbchitieu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reasion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lbMont = new System.Windows.Forms.Label();
            this.lbMonx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThanhToanXau = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToanNoTots = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvNoXau = new System.Windows.Forms.DataGridView();
            this.Moneys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNoTot = new System.Windows.Forms.DataGridView();
            this.Moneyss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.navigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoXau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTot)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeNow
            // 
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Location = new System.Drawing.Point(1, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1337, 815);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 1;
            this.navigationPane1.Size = new System.Drawing.Size(1337, 815);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Hệ Thống";
            this.navigationPage1.Controls.Add(this.simpleButton5);
            this.navigationPage1.Controls.Add(this.simpleButton4);
            this.navigationPage1.Controls.Add(this.lbTen);
            this.navigationPage1.Controls.Add(this.Namesss);
            this.navigationPage1.Controls.Add(this.panel1);
            this.navigationPage1.Controls.Add(this.simpleButton3);
            this.navigationPage1.Controls.Add(this.lbTien);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Controls.Add(this.simpleButton2);
            this.navigationPage1.Controls.Add(this.simpleButton1);
            this.navigationPage1.ImageUri.Uri = "Pie";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1263, 745);
            this.navigationPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage1_Paint);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(14, 325);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(138, 45);
            this.simpleButton5.TabIndex = 10;
            this.simpleButton5.Text = "Sắp xếp giảm";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(14, 263);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(138, 45);
            this.simpleButton4.TabIndex = 9;
            this.simpleButton4.Text = "Sắp xếp tăng";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTen.Location = new System.Drawing.Point(284, 71);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(139, 30);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "Họ Và Tên";
            // 
            // Namesss
            // 
            this.Namesss.AutoSize = true;
            this.Namesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namesss.ForeColor = System.Drawing.Color.Red;
            this.Namesss.Location = new System.Drawing.Point(284, 31);
            this.Namesss.Name = "Namesss";
            this.Namesss.Size = new System.Drawing.Size(57, 25);
            this.Namesss.TabIndex = 7;
            this.Namesss.Text = "Tên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(177, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 468);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngays,
            this.SoTien});
            this.dataGridView1.Location = new System.Drawing.Point(49, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 460);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ngays
            // 
            this.Ngays.DataPropertyName = "Ngay";
            this.Ngays.HeaderText = "Ngày";
            this.Ngays.Name = "Ngays";
            this.Ngays.Width = 325;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 350;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(14, 131);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(138, 45);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "In thống kê ";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTien.Location = new System.Drawing.Point(674, 71);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(123, 39);
            this.lbTien.TabIndex = 3;
            this.lbTien.Text = "0 VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(676, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(14, 71);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 41);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Đăng xuất";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(14, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Quản Lý Chi Tiêu";
            this.navigationPage2.Controls.Add(this.btnXoa);
            this.navigationPage2.Controls.Add(this.lbchitieu);
            this.navigationPage2.Controls.Add(this.label3);
            this.navigationPage2.Controls.Add(this.simpleButton13);
            this.navigationPage2.Controls.Add(this.simpleButton12);
            this.navigationPage2.Controls.Add(this.simpleButton11);
            this.navigationPage2.Controls.Add(this.simpleButton10);
            this.navigationPage2.Controls.Add(this.panel2);
            this.navigationPage2.Controls.Add(this.simpleButton7);
            this.navigationPage2.Controls.Add(this.simpleButton8);
            this.navigationPage2.Controls.Add(this.simpleButton9);
            this.navigationPage2.Controls.Add(this.simpleButton6);
            this.navigationPage2.ImageUri.Uri = "Chart";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1263, 745);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(20, 79);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 45);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa chi tiêu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbchitieu
            // 
            this.lbchitieu.AutoSize = true;
            this.lbchitieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchitieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbchitieu.Location = new System.Drawing.Point(503, 64);
            this.lbchitieu.Name = "lbchitieu";
            this.lbchitieu.Size = new System.Drawing.Size(123, 39);
            this.lbchitieu.TabIndex = 20;
            this.lbchitieu.Text = "0 VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(493, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng chi tiêu:";
            // 
            // simpleButton13
            // 
            this.simpleButton13.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.Image")));
            this.simpleButton13.Location = new System.Drawing.Point(20, 518);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(138, 45);
            this.simpleButton13.TabIndex = 18;
            this.simpleButton13.Text = "Tất cả";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton12.Image")));
            this.simpleButton12.Location = new System.Drawing.Point(20, 467);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(138, 45);
            this.simpleButton12.TabIndex = 17;
            this.simpleButton12.Text = "Tháng này";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(20, 414);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(138, 45);
            this.simpleButton11.TabIndex = 16;
            this.simpleButton11.Text = "Tuần này";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.Image")));
            this.simpleButton10.Location = new System.Drawing.Point(20, 363);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(138, 45);
            this.simpleButton10.TabIndex = 15;
            this.simpleButton10.Text = "Hôm nay";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(203, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 458);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Money,
            this.Reasion});
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView2.Location = new System.Drawing.Point(23, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(685, 440);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 200;
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "Số tiền";
            this.Money.Name = "Money";
            this.Money.Width = 200;
            // 
            // Reasion
            // 
            this.Reasion.DataPropertyName = "Reasion";
            this.Reasion.HeaderText = "Lý do";
            this.Reasion.Name = "Reasion";
            this.Reasion.Width = 240;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(20, 277);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(138, 45);
            this.simpleButton7.TabIndex = 13;
            this.simpleButton7.Text = "Sắp xếp giảm";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(20, 215);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(138, 45);
            this.simpleButton8.TabIndex = 12;
            this.simpleButton8.Text = "Sắp xếp tăng";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(20, 136);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(138, 45);
            this.simpleButton9.TabIndex = 11;
            this.simpleButton9.Text = "In thống kê ";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(20, 26);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(138, 42);
            this.simpleButton6.TabIndex = 3;
            this.simpleButton6.Text = "Tạo chi tiêu";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Quản Lý Nguồn Tiền";
            this.navigationPage3.Controls.Add(this.lbMont);
            this.navigationPage3.Controls.Add(this.lbMonx);
            this.navigationPage3.Controls.Add(this.label7);
            this.navigationPage3.Controls.Add(this.label8);
            this.navigationPage3.Controls.Add(this.btnThanhToanXau);
            this.navigationPage3.Controls.Add(this.label4);
            this.navigationPage3.Controls.Add(this.label2);
            this.navigationPage3.Controls.Add(this.btnThanhToanNoTots);
            this.navigationPage3.Controls.Add(this.simpleButton16);
            this.navigationPage3.Controls.Add(this.simpleButton15);
            this.navigationPage3.Controls.Add(this.simpleButton14);
            this.navigationPage3.Controls.Add(this.dgvNoXau);
            this.navigationPage3.Controls.Add(this.dgvNoTot);
            this.navigationPage3.ImageUri.Uri = "Currency";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(1263, 745);
            this.navigationPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage3_Paint);
            // 
            // lbMont
            // 
            this.lbMont.AutoSize = true;
            this.lbMont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMont.ForeColor = System.Drawing.Color.Green;
            this.lbMont.Location = new System.Drawing.Point(151, 532);
            this.lbMont.Name = "lbMont";
            this.lbMont.Size = new System.Drawing.Size(75, 25);
            this.lbMont.TabIndex = 19;
            this.lbMont.Text = "0 VNĐ";
            // 
            // lbMonx
            // 
            this.lbMonx.AutoSize = true;
            this.lbMonx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonx.ForeColor = System.Drawing.Color.Teal;
            this.lbMonx.Location = new System.Drawing.Point(706, 532);
            this.lbMonx.Name = "lbMonx";
            this.lbMonx.Size = new System.Drawing.Size(75, 25);
            this.lbMonx.TabIndex = 21;
            this.lbMonx.Text = "0 VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tổng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tổng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnThanhToanXau
            // 
            this.btnThanhToanXau.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToanXau.Image")));
            this.btnThanhToanXau.Location = new System.Drawing.Point(449, 425);
            this.btnThanhToanXau.Name = "btnThanhToanXau";
            this.btnThanhToanXau.Size = new System.Drawing.Size(138, 45);
            this.btnThanhToanXau.TabIndex = 18;
            this.btnThanhToanXau.Text = "Thanh toán";
            this.btnThanhToanXau.Click += new System.EventHandler(this.btnThanhToanXau_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(720, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nguồn nợ xấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(120, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nguồn tiền lưu động";
            // 
            // btnThanhToanNoTots
            // 
            this.btnThanhToanNoTots.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToanNoTots.Image")));
            this.btnThanhToanNoTots.Location = new System.Drawing.Point(449, 249);
            this.btnThanhToanNoTots.Name = "btnThanhToanNoTots";
            this.btnThanhToanNoTots.Size = new System.Drawing.Size(138, 45);
            this.btnThanhToanNoTots.TabIndex = 15;
            this.btnThanhToanNoTots.Text = "Thanh toán";
            this.btnThanhToanNoTots.Click += new System.EventHandler(this.btnThanhToanNoTots_Click);
            // 
            // simpleButton16
            // 
            this.simpleButton16.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton16.Image")));
            this.simpleButton16.Location = new System.Drawing.Point(449, 374);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(138, 45);
            this.simpleButton16.TabIndex = 14;
            this.simpleButton16.Text = "Thêm nợ xấu";
            this.simpleButton16.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // simpleButton15
            // 
            this.simpleButton15.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton15.Image")));
            this.simpleButton15.Location = new System.Drawing.Point(449, 198);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(138, 45);
            this.simpleButton15.TabIndex = 13;
            this.simpleButton15.Text = "Thêm TLĐ";
            this.simpleButton15.Click += new System.EventHandler(this.simpleButton15_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton14.Image")));
            this.simpleButton14.Location = new System.Drawing.Point(449, 81);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(138, 45);
            this.simpleButton14.TabIndex = 12;
            this.simpleButton14.Text = "Thu nhập";
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // dgvNoXau
            // 
            this.dgvNoXau.AllowUserToAddRows = false;
            this.dgvNoXau.AllowUserToDeleteRows = false;
            this.dgvNoXau.AllowUserToOrderColumns = true;
            this.dgvNoXau.AllowUserToResizeColumns = false;
            this.dgvNoXau.AllowUserToResizeRows = false;
            this.dgvNoXau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoXau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moneys,
            this.GhiChus});
            this.dgvNoXau.Location = new System.Drawing.Point(621, 81);
            this.dgvNoXau.Name = "dgvNoXau";
            this.dgvNoXau.RowTemplate.Height = 24;
            this.dgvNoXau.ShowCellToolTips = false;
            this.dgvNoXau.ShowEditingIcon = false;
            this.dgvNoXau.ShowRowErrors = false;
            this.dgvNoXau.Size = new System.Drawing.Size(353, 434);
            this.dgvNoXau.TabIndex = 4;
            this.dgvNoXau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            this.dgvNoXau.Leave += new System.EventHandler(this.dataGridView4_Leave);
            // 
            // Moneys
            // 
            this.Moneys.DataPropertyName = "Money";
            this.Moneys.HeaderText = "Số Tiền";
            this.Moneys.Name = "Moneys";
            // 
            // GhiChus
            // 
            this.GhiChus.DataPropertyName = "GhiChu";
            this.GhiChus.HeaderText = "Ghi Chú";
            this.GhiChus.Name = "GhiChus";
            this.GhiChus.Width = 210;
            // 
            // dgvNoTot
            // 
            this.dgvNoTot.AllowUserToAddRows = false;
            this.dgvNoTot.AllowUserToDeleteRows = false;
            this.dgvNoTot.AllowUserToOrderColumns = true;
            this.dgvNoTot.AllowUserToResizeColumns = false;
            this.dgvNoTot.AllowUserToResizeRows = false;
            this.dgvNoTot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoTot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moneyss,
            this.GhiChuss});
            this.dgvNoTot.Location = new System.Drawing.Point(39, 81);
            this.dgvNoTot.Name = "dgvNoTot";
            this.dgvNoTot.RowTemplate.Height = 24;
            this.dgvNoTot.ShowCellErrors = false;
            this.dgvNoTot.ShowCellToolTips = false;
            this.dgvNoTot.ShowEditingIcon = false;
            this.dgvNoTot.ShowRowErrors = false;
            this.dgvNoTot.Size = new System.Drawing.Size(354, 434);
            this.dgvNoTot.TabIndex = 3;
            this.dgvNoTot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Moneyss
            // 
            this.Moneyss.DataPropertyName = "Money";
            this.Moneyss.HeaderText = "Số Tiền";
            this.Moneyss.Name = "Moneyss";
            // 
            // GhiChuss
            // 
            this.GhiChuss.DataPropertyName = "GhiChu";
            this.GhiChuss.HeaderText = "Ghi Chú";
            this.GhiChuss.Name = "GhiChuss";
            this.GhiChuss.Width = 210;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb.Location = new System.Drawing.Point(456, 264);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(138, 17);
            this.lb.TabIndex = 4;
            this.lb.Text = "Bản quyền thuộc về ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(489, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kha đẹp trai";
            // 
            // frmTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 757);
            this.ControlBox = false;
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TIÊU DÙNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.SizeChanged += new System.EventHandler(this.frmTrangChu_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrangChu_KeyDown);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoXau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeNow;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label Namesss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTen;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private System.Windows.Forms.Label lbchitieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reasion;
        private System.Windows.Forms.DataGridView dgvNoXau;
        private System.Windows.Forms.DataGridView dgvNoTot;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnThanhToanNoTots;
        private DevExpress.XtraEditors.SimpleButton simpleButton16;
        private DevExpress.XtraEditors.SimpleButton simpleButton15;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngays;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private DevExpress.XtraEditors.SimpleButton btnThanhToanXau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneys;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMonx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneyss;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuss;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}