namespace WinForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSXIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPIDDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.nhaSXIDDataGridViewTextBoxColumn,
            this.manhinhDataGridViewTextBoxColumn,
            this.rAMDataGridViewTextBoxColumn,
            this.cPUDataGridViewTextBoxColumn,
            this.pinDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.hinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanPhamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(491, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sanPhamBindingSource
            // 
            // 
            // sPIDDataGridViewTextBoxColumn
            // 
            this.sPIDDataGridViewTextBoxColumn.DataPropertyName = "SP_ID";
            this.sPIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.sPIDDataGridViewTextBoxColumn.Name = "sPIDDataGridViewTextBoxColumn";
            this.sPIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhaSXIDDataGridViewTextBoxColumn
            // 
            this.nhaSXIDDataGridViewTextBoxColumn.DataPropertyName = "NhaSX_ID";
            this.nhaSXIDDataGridViewTextBoxColumn.HeaderText = "Id nhà SX";
            this.nhaSXIDDataGridViewTextBoxColumn.Name = "nhaSXIDDataGridViewTextBoxColumn";
            this.nhaSXIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manhinhDataGridViewTextBoxColumn
            // 
            this.manhinhDataGridViewTextBoxColumn.DataPropertyName = "Manhinh";
            this.manhinhDataGridViewTextBoxColumn.HeaderText = "Màn hình";
            this.manhinhDataGridViewTextBoxColumn.Name = "manhinhDataGridViewTextBoxColumn";
            this.manhinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAMDataGridViewTextBoxColumn
            // 
            this.rAMDataGridViewTextBoxColumn.DataPropertyName = "RAM";
            this.rAMDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.rAMDataGridViewTextBoxColumn.Name = "rAMDataGridViewTextBoxColumn";
            this.rAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUDataGridViewTextBoxColumn
            // 
            this.cPUDataGridViewTextBoxColumn.DataPropertyName = "CPU";
            this.cPUDataGridViewTextBoxColumn.HeaderText = "CPU";
            this.cPUDataGridViewTextBoxColumn.Name = "cPUDataGridViewTextBoxColumn";
            this.cPUDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pinDataGridViewTextBoxColumn
            // 
            this.pinDataGridViewTextBoxColumn.DataPropertyName = "Pin";
            this.pinDataGridViewTextBoxColumn.HeaderText = "Pin";
            this.pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            this.pinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhDataGridViewTextBoxColumn
            // 
            this.hinhDataGridViewTextBoxColumn.DataPropertyName = "Hinh";
            this.hinhDataGridViewTextBoxColumn.HeaderText = "Hình";
            this.hinhDataGridViewTextBoxColumn.Name = "hinhDataGridViewTextBoxColumn";
            this.hinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSXIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhDataGridViewTextBoxColumn;
    }
}

