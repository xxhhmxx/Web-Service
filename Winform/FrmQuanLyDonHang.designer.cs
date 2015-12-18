namespace WinForm
{
    partial class FrmQuanLyDonHang
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
            this.ViewDonHang = new System.Windows.Forms.DataGridView();
            this.maDonDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatDH = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.tabQuanLyHoaDon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua_DH = new System.Windows.Forms.Button();
            this.cbTinhTrang_Sua = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewCT_DH = new System.Windows.Forms.DataGridView();
            this.maDonDHDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDonDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDHBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabQuanLyHoaDon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCT_DH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewDonHang
            // 
            this.ViewDonHang.AllowUserToAddRows = false;
            this.ViewDonHang.AllowUserToDeleteRows = false;
            this.ViewDonHang.AutoGenerateColumns = false;
            this.ViewDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonDHDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ngayDatDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.ViewDonHang.DataSource = this.donDHBindingSource;
            this.ViewDonHang.Location = new System.Drawing.Point(6, 7);
            this.ViewDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewDonHang.Name = "ViewDonHang";
            this.ViewDonHang.ReadOnly = true;
            this.ViewDonHang.Size = new System.Drawing.Size(836, 197);
            this.ViewDonHang.TabIndex = 0;
            this.ViewDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDonHang_CellContentClick);
            this.ViewDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDonHang_CellContentClick);
            // 
            // maDonDHDataGridViewTextBoxColumn
            // 
            this.maDonDHDataGridViewTextBoxColumn.DataPropertyName = "MaDonDH";
            this.maDonDHDataGridViewTextBoxColumn.HeaderText = "MaDonDH";
            this.maDonDHDataGridViewTextBoxColumn.Name = "maDonDHDataGridViewTextBoxColumn";
            this.maDonDHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayDatDataGridViewTextBoxColumn
            // 
            this.ngayDatDataGridViewTextBoxColumn.DataPropertyName = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.HeaderText = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.Name = "ngayDatDataGridViewTextBoxColumn";
            this.ngayDatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donDHBindingSource
            // 
            this.donDHBindingSource.DataSource = typeof(Winform.QuanLyDonHangServiceReference.DonDH);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatDH);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbTinhTrang);
            this.groupBox1.Controls.Add(this.cbTim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtNgayDat);
            this.groupBox1.Controls.Add(this.txtMaDonHang);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(814, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnCapNhatDH
            // 
            this.btnCapNhatDH.Location = new System.Drawing.Point(197, 92);
            this.btnCapNhatDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatDH.Name = "btnCapNhatDH";
            this.btnCapNhatDH.Size = new System.Drawing.Size(155, 34);
            this.btnCapNhatDH.TabIndex = 5;
            this.btnCapNhatDH.Text = "Hiển Thị Đơn Hàng";
            this.btnCapNhatDH.UseVisualStyleBackColor = true;
            this.btnCapNhatDH.Click += new System.EventHandler(this.btnCapNhatDH_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(393, 92);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đã Giao",
            "Chưa Giao"});
            this.cbTinhTrang.Location = new System.Drawing.Point(628, 37);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(146, 28);
            this.cbTinhTrang.TabIndex = 4;
            // 
            // cbTim
            // 
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Items.AddRange(new object[] {
            "Mã Đơn Hàng",
            "Ngày Đặt",
            "Tình Trạng"});
            this.cbTim.Location = new System.Drawing.Point(120, 37);
            this.cbTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(130, 28);
            this.cbTim.TabIndex = 1;
            this.cbTim.SelectedIndexChanged += new System.EventHandler(this.cbTim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(465, 40);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(132, 25);
            this.dtNgayDat.TabIndex = 3;
            this.dtNgayDat.Value = new System.DateTime(2015, 12, 2, 0, 0, 0, 0);
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(277, 40);
            this.txtMaDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(144, 25);
            this.txtMaDonHang.TabIndex = 2;
            // 
            // tabQuanLyHoaDon
            // 
            this.tabQuanLyHoaDon.Controls.Add(this.tabPage1);
            this.tabQuanLyHoaDon.Controls.Add(this.tabPage2);
            this.tabQuanLyHoaDon.Location = new System.Drawing.Point(1, 4);
            this.tabQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabQuanLyHoaDon.Name = "tabQuanLyHoaDon";
            this.tabQuanLyHoaDon.SelectedIndex = 0;
            this.tabQuanLyHoaDon.Size = new System.Drawing.Size(868, 490);
            this.tabQuanLyHoaDon.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.ViewDonHang);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(860, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSua_DH);
            this.groupBox3.Controls.Add(this.cbTinhTrang_Sua);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 362);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(814, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa Tổng Tiền - Tình Trạng";
            // 
            // btnSua_DH
            // 
            this.btnSua_DH.Location = new System.Drawing.Point(668, 34);
            this.btnSua_DH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua_DH.Name = "btnSua_DH";
            this.btnSua_DH.Size = new System.Drawing.Size(75, 34);
            this.btnSua_DH.TabIndex = 6;
            this.btnSua_DH.Text = "Cập Nhật";
            this.btnSua_DH.UseVisualStyleBackColor = true;
            this.btnSua_DH.Click += new System.EventHandler(this.btnSua_DH_Click);
            // 
            // cbTinhTrang_Sua
            // 
            this.cbTinhTrang_Sua.FormattingEnabled = true;
            this.cbTinhTrang_Sua.Items.AddRange(new object[] {
            "Đã Giao",
            "Chưa Giao"});
            this.cbTinhTrang_Sua.Location = new System.Drawing.Point(447, 35);
            this.cbTinhTrang_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTinhTrang_Sua.Name = "cbTinhTrang_Sua";
            this.cbTinhTrang_Sua.Size = new System.Drawing.Size(130, 28);
            this.cbTinhTrang_Sua.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(120, 35);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(144, 25);
            this.txtTongTien.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tình Trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng Tiền";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLuu);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.gbThongTin);
            this.tabPage2.Controls.Add(this.ViewCT_DH);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(860, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Hóa Đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(124, 378);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(7, 378);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtEmail);
            this.gbThongTin.Controls.Add(this.txtDienThoai);
            this.gbThongTin.Controls.Add(this.txtTenKhachHang);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Location = new System.Drawing.Point(8, 217);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTin.Size = new System.Drawing.Size(837, 134);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Đặt Hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(505, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(142, 61);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(168, 20);
            this.txtDienThoai.TabIndex = 6;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(142, 22);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(168, 20);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(505, 24);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(168, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // ViewCT_DH
            // 
            this.ViewCT_DH.AllowUserToAddRows = false;
            this.ViewCT_DH.AllowUserToDeleteRows = false;
            this.ViewCT_DH.AutoGenerateColumns = false;
            this.ViewCT_DH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCT_DH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonDHDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.ViewCT_DH.DataSource = this.cTDonDHBindingSource;
            this.ViewCT_DH.Location = new System.Drawing.Point(7, 18);
            this.ViewCT_DH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewCT_DH.Name = "ViewCT_DH";
            this.ViewCT_DH.ReadOnly = true;
            this.ViewCT_DH.Size = new System.Drawing.Size(688, 177);
            this.ViewCT_DH.TabIndex = 0;
            this.ViewCT_DH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // maDonDHDataGridViewTextBoxColumn2
            // 
            this.maDonDHDataGridViewTextBoxColumn2.DataPropertyName = "MaDonDH";
            this.maDonDHDataGridViewTextBoxColumn2.HeaderText = "MaDonDH";
            this.maDonDHDataGridViewTextBoxColumn2.Name = "maDonDHDataGridViewTextBoxColumn2";
            this.maDonDHDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SP_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SP_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DonGiaDat";
            this.dataGridViewTextBoxColumn1.HeaderText = "DonGiaDat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuongDat";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuongDat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cTDonDHBindingSource
            // 
            this.cTDonDHBindingSource.DataSource = typeof(Winform.CT_DHServiceReference.CT_DonDH);
            // 
            // FrmQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.Controls.Add(this.tabQuanLyHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyDonHang";
            this.Text = "QuanLyDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.ViewDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDHBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuanLyHoaDon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCT_DH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewDonHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabQuanLyHoaDon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ViewCT_DH;
        private System.Windows.Forms.Button btnCapNhatDH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSua_DH;
        private System.Windows.Forms.ComboBox cbTinhTrang_Sua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonDHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donDHBindingSource;
        private System.Windows.Forms.BindingSource cTDonDHBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonDHDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}