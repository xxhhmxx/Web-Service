namespace WinForm
{
    partial class FrmPhieuNhap
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
            this.tabQuanLyHoaDon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhaSanXuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttkMaNhaSanXuat = new System.Windows.Forms.TextBox();
            this.btnCapNhatPhieuNhap = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dttkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txttkMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLuuCTPN = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabQuanLyHoaDon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQuanLyHoaDon
            // 
            this.tabQuanLyHoaDon.Controls.Add(this.tabPage1);
            this.tabQuanLyHoaDon.Controls.Add(this.tabPage2);
            this.tabQuanLyHoaDon.Location = new System.Drawing.Point(2, -1);
            this.tabQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabQuanLyHoaDon.Name = "tabQuanLyHoaDon";
            this.tabQuanLyHoaDon.SelectedIndex = 0;
            this.tabQuanLyHoaDon.Size = new System.Drawing.Size(887, 630);
            this.tabQuanLyHoaDon.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(879, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtMaNhaSanXuat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnLuuPhieuNhap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtNgayNhap);
            this.groupBox3.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 377);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(814, 229);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm Phiếu Nhập";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(235, 167);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 38);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(465, 103);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(144, 25);
            this.txtTongTien.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tổng Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày Nhập";
            // 
            // txtMaNhaSanXuat
            // 
            this.txtMaNhaSanXuat.Location = new System.Drawing.Point(138, 109);
            this.txtMaNhaSanXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhaSanXuat.Name = "txtMaNhaSanXuat";
            this.txtMaNhaSanXuat.Size = new System.Drawing.Size(144, 25);
            this.txtMaNhaSanXuat.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã Nhà Sản Xuât";
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(399, 167);
            this.btnLuuPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(110, 38);
            this.btnLuuPhieuNhap.TabIndex = 2;
            this.btnLuuPhieuNhap.Text = "Lưu";
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Phiếu Nhập";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(465, 59);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(144, 25);
            this.dtNgayNhap.TabIndex = 3;
            this.dtNgayNhap.Value = new System.DateTime(2015, 12, 2, 0, 0, 0, 0);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(138, 60);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(144, 25);
            this.txtMaPhieuNhap.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(28, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Nhà Sản Xuất";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Nhập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttkMaNhaSanXuat);
            this.groupBox1.Controls.Add(this.btnCapNhatPhieuNhap);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbTim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dttkNgayNhap);
            this.groupBox1.Controls.Add(this.txttkMaPhieuNhap);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(814, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txttkMaNhaSanXuat
            // 
            this.txttkMaNhaSanXuat.Location = new System.Drawing.Point(465, 59);
            this.txttkMaNhaSanXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttkMaNhaSanXuat.Name = "txttkMaNhaSanXuat";
            this.txttkMaNhaSanXuat.Size = new System.Drawing.Size(144, 25);
            this.txttkMaNhaSanXuat.TabIndex = 6;
            // 
            // btnCapNhatPhieuNhap
            // 
            this.btnCapNhatPhieuNhap.Location = new System.Drawing.Point(346, 109);
            this.btnCapNhatPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatPhieuNhap.Name = "btnCapNhatPhieuNhap";
            this.btnCapNhatPhieuNhap.Size = new System.Drawing.Size(75, 38);
            this.btnCapNhatPhieuNhap.TabIndex = 5;
            this.btnCapNhatPhieuNhap.Text = "Cập Nhật";
            this.btnCapNhatPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(465, 109);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 38);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbTim
            // 
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Items.AddRange(new object[] {
            "Mã Phiếu Nhập",
            "Mã NhàSản Xuất",
            "Ngày Nhập"});
            this.cbTim.Location = new System.Drawing.Point(123, 56);
            this.cbTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(130, 28);
            this.cbTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // dttkNgayNhap
            // 
            this.dttkNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dttkNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttkNgayNhap.Location = new System.Drawing.Point(656, 59);
            this.dttkNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dttkNgayNhap.Name = "dttkNgayNhap";
            this.dttkNgayNhap.Size = new System.Drawing.Size(132, 25);
            this.dttkNgayNhap.TabIndex = 3;
            this.dttkNgayNhap.Value = new System.DateTime(2015, 12, 2, 0, 0, 0, 0);
            // 
            // txttkMaPhieuNhap
            // 
            this.txttkMaPhieuNhap.Location = new System.Drawing.Point(277, 60);
            this.txttkMaPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttkMaPhieuNhap.Name = "txttkMaPhieuNhap";
            this.txttkMaPhieuNhap.Size = new System.Drawing.Size(144, 25);
            this.txttkMaPhieuNhap.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLuuCTPN);
            this.tabPage2.Controls.Add(this.btnCapNhat);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(879, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLuuCTPN
            // 
            this.btnLuuCTPN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCTPN.Location = new System.Drawing.Point(187, 347);
            this.btnLuuCTPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuCTPN.Name = "btnLuuCTPN";
            this.btnLuuCTPN.Size = new System.Drawing.Size(85, 32);
            this.btnLuuCTPN.TabIndex = 3;
            this.btnLuuCTPN.Text = "Lưu";
            this.btnLuuCTPN.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(81, 347);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 32);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column11});
            this.dataGridView2.Location = new System.Drawing.Point(7, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(846, 305);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã Phiếu Nhập";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mã Sản Phẩm";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Số Lượng";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Đơn Giá";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 200;
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 612);
            this.Controls.Add(this.tabQuanLyHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            this.tabQuanLyHoaDon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLyHoaDon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttkNgayNhap;
        private System.Windows.Forms.TextBox txttkMaPhieuNhap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLuuCTPN;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhaSanXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuuPhieuNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCapNhatPhieuNhap;
        private System.Windows.Forms.TextBox txttkMaNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}