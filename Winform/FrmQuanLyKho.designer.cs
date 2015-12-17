namespace WinForm
{
    partial class FrmQuanLyKho
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
            this.ViewQuanLyKho = new System.Windows.Forms.DataGridView();
            this.sPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.cbSoLuongTon = new System.Windows.Forms.ComboBox();
            this.pnThoiGian = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuanLyKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonKhoBindingSource)).BeginInit();
            this.pnThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewQuanLyKho
            // 
            this.ViewQuanLyKho.AllowUserToAddRows = false;
            this.ViewQuanLyKho.AllowUserToDeleteRows = false;
            this.ViewQuanLyKho.AutoGenerateColumns = false;
            this.ViewQuanLyKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewQuanLyKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPIDDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn});
            this.ViewQuanLyKho.DataSource = this.tonKhoBindingSource;
            this.ViewQuanLyKho.GridColor = System.Drawing.Color.Black;
            this.ViewQuanLyKho.Location = new System.Drawing.Point(12, 12);
            this.ViewQuanLyKho.Name = "ViewQuanLyKho";
            this.ViewQuanLyKho.ReadOnly = true;
            this.ViewQuanLyKho.Size = new System.Drawing.Size(645, 201);
            this.ViewQuanLyKho.TabIndex = 0;
            // 
            // sPIDDataGridViewTextBoxColumn
            // 
            this.sPIDDataGridViewTextBoxColumn.DataPropertyName = "SP_ID";
            this.sPIDDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.sPIDDataGridViewTextBoxColumn.Name = "sPIDDataGridViewTextBoxColumn";
            this.sPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Số Lượng Tồn Kho";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongTonDataGridViewTextBoxColumn.Width = 200;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Thời Gian Tồn";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianDataGridViewTextBoxColumn.Width = 200;
            // 
            // tonKhoBindingSource
            // 
            this.tonKhoBindingSource.DataSource = typeof(Winform.QuanLyTonKhoServiceReference.TonKho);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời Gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng Tồn";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(166, 283);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(147, 20);
            this.txtMaSanPham.TabIndex = 7;
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "MM/dd/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(148, 59);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 20);
            this.dtDen.TabIndex = 10;
            this.dtDen.Value = new System.DateTime(2015, 12, 24, 0, 0, 0, 0);
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "MM/dd/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(148, 14);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 20);
            this.dtTu.TabIndex = 11;
            this.dtTu.Value = new System.DateTime(2015, 12, 2, 11, 2, 5, 0);
            this.dtTu.ValueChanged += new System.EventHandler(this.dtTu_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đến";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(189, 382);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(124, 29);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tìm Kiếm Theo";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã Sản Phẩm",
            "Số Lượng Tồn",
            "Thời Gian"});
            this.cbTimKiem.Location = new System.Drawing.Point(166, 248);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(147, 19);
            this.cbTimKiem.TabIndex = 17;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            // 
            // cbSoLuongTon
            // 
            this.cbSoLuongTon.FormattingEnabled = true;
            this.cbSoLuongTon.Items.AddRange(new object[] {
            "Giảm dần",
            "Tăng dần"});
            this.cbSoLuongTon.Location = new System.Drawing.Point(166, 326);
            this.cbSoLuongTon.Name = "cbSoLuongTon";
            this.cbSoLuongTon.Size = new System.Drawing.Size(147, 19);
            this.cbSoLuongTon.TabIndex = 18;
            // 
            // pnThoiGian
            // 
            this.pnThoiGian.Controls.Add(this.label3);
            this.pnThoiGian.Controls.Add(this.dtDen);
            this.pnThoiGian.Controls.Add(this.label5);
            this.pnThoiGian.Controls.Add(this.label6);
            this.pnThoiGian.Controls.Add(this.dtTu);
            this.pnThoiGian.Location = new System.Drawing.Point(362, 248);
            this.pnThoiGian.Name = "pnThoiGian";
            this.pnThoiGian.Size = new System.Drawing.Size(271, 100);
            this.pnThoiGian.TabIndex = 19;
            // 
            // FrmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 442);
            this.Controls.Add(this.pnThoiGian);
            this.Controls.Add(this.cbSoLuongTon);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewQuanLyKho);
            this.Name = "FrmQuanLyKho";
            this.Text = "FrmQuanLyKho";
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuanLyKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonKhoBindingSource)).EndInit();
            this.pnThoiGian.ResumeLayout(false);
            this.pnThoiGian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewQuanLyKho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.ComboBox cbSoLuongTon;
        private System.Windows.Forms.BindingSource tonKhoBindingSource;
        private System.Windows.Forms.Panel pnThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
    }
}