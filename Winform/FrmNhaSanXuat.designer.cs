namespace WinForm
{
    partial class FrmNhaSanXuat
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
            this.ViewNSX = new System.Windows.Forms.DataGridView();
            this.nhaSXIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenNhaSanXuat = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewNSX
            // 
            this.ViewNSX.AllowUserToAddRows = false;
            this.ViewNSX.AllowUserToDeleteRows = false;
            this.ViewNSX.AutoGenerateColumns = false;
            this.ViewNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhaSXIDDataGridViewTextBoxColumn,
            this.tenNhaSXDataGridViewTextBoxColumn});
            this.ViewNSX.DataSource = this.nhaSXBindingSource;
            this.ViewNSX.Location = new System.Drawing.Point(12, 12);
            this.ViewNSX.Name = "ViewNSX";
            this.ViewNSX.ReadOnly = true;
            this.ViewNSX.Size = new System.Drawing.Size(445, 150);
            this.ViewNSX.TabIndex = 0;
            this.ViewNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewNSX_Click);
            this.ViewNSX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewNSX_Click);
            this.ViewNSX.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewNSX_CellMouseClick);
            // 
            // nhaSXIDDataGridViewTextBoxColumn
            // 
            this.nhaSXIDDataGridViewTextBoxColumn.DataPropertyName = "NhaSX_ID";
            this.nhaSXIDDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Sản Xuất";
            this.nhaSXIDDataGridViewTextBoxColumn.Name = "nhaSXIDDataGridViewTextBoxColumn";
            this.nhaSXIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nhaSXIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenNhaSXDataGridViewTextBoxColumn
            // 
            this.tenNhaSXDataGridViewTextBoxColumn.DataPropertyName = "TenNhaSX";
            this.tenNhaSXDataGridViewTextBoxColumn.HeaderText = "Tên Nhà Sản Xuất";
            this.tenNhaSXDataGridViewTextBoxColumn.Name = "tenNhaSXDataGridViewTextBoxColumn";
            this.tenNhaSXDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhaSXDataGridViewTextBoxColumn.Width = 200;
            // 
            // nhaSXBindingSource
            // 
            this.nhaSXBindingSource.DataSource = typeof(Winform.QuanLyNhaSXServiceReference.NhaSX);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Sản Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà Sản Xuất";
            // 
            // txtMaNhaSanXuat
            // 
            this.txtMaNhaSanXuat.Location = new System.Drawing.Point(161, 194);
            this.txtMaNhaSanXuat.Name = "txtMaNhaSanXuat";
            this.txtMaNhaSanXuat.Size = new System.Drawing.Size(148, 20);
            this.txtMaNhaSanXuat.TabIndex = 3;
            // 
            // txtTenNhaSanXuat
            // 
            this.txtTenNhaSanXuat.Location = new System.Drawing.Point(161, 226);
            this.txtTenNhaSanXuat.Name = "txtTenNhaSanXuat";
            this.txtTenNhaSanXuat.Size = new System.Drawing.Size(148, 20);
            this.txtTenNhaSanXuat.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(12, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 27);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 278);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 27);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(161, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 27);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(307, 278);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 27);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 364);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenNhaSanXuat);
            this.Controls.Add(this.txtMaNhaSanXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewNSX);
            this.Name = "FrmNhaSanXuat";
            this.Text = "FrmNhaSanXuat";
            ((System.ComponentModel.ISupportInitialize)(this.ViewNSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewNSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhaSanXuat;
        private System.Windows.Forms.TextBox txtTenNhaSanXuat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource nhaSXBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSXIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaSXDataGridViewTextBoxColumn;
    }
}