using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.QuanLyNhaSXServiceReference;

namespace WinForm
{
    public partial class FrmNhaSanXuat : Form
    {
        QuanLyNhaSxServiceClient qlnsx = new QuanLyNhaSxServiceClient();
        NhaSX nsx = new NhaSX();
        bool them_moi = false;
        public FrmNhaSanXuat()
        {
            InitializeComponent();
            Ds_NhaSX();
            txtMaNhaSanXuat.Enabled = false;
            txtTenNhaSanXuat.Enabled = false;
        }
        public void Ds_NhaSX()
        {
            ViewNSX.AutoGenerateColumns = false;
            ViewNSX.DataSource = qlnsx.HienThiNhaSX();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtTenNhaSanXuat.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenNhaSanXuat.Enabled = true;
            LamMoi();
            them_moi = true;
            CheMo(true);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (them_moi == true)
            {
                if (txtTenNhaSanXuat.Text != "")
                {
                    try
                    {
                        nsx.TenNhaSX = txtTenNhaSanXuat.Text.Trim();
                        qlnsx.Them(nsx);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            else
            {
                if (txtTenNhaSanXuat.Text != "")
                {
                    try
                    {
                        nsx.TenNhaSX = txtTenNhaSanXuat.Text.Trim();
                        qlnsx.Sua(nsx);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            CheMo(false);

            Ds_NhaSX();
        }

        private void LamMoi()
        {
            txtMaNhaSanXuat.Text = "";
            txtTenNhaSanXuat.Text = "";
        }
        //Hàm tự viết
        //làm mờ các control
        void CheMo(bool trangthai)
        {
            btnThem.Enabled = !trangthai;
            btnSua.Enabled = !trangthai;
            btnXoa.Enabled = !trangthai;
            btnLuu.Enabled = trangthai;
            txtTenNhaSanXuat.Enabled = trangthai;
        }

        private void ViewNSX_Click(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = ViewNSX.CurrentRow.Index;
            List<NhaSX> list = qlnsx.HienThiNhaSX().ToList();
            nsx = list[vitri];
            txtMaNhaSanXuat.Text = nsx.NhaSX_ID.ToString();
            txtTenNhaSanXuat.Text = nsx.TenNhaSX.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhà cung cấp", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    nsx.NhaSX_ID = int.Parse(txtMaNhaSanXuat.Text);
                    qlnsx.Xoa(nsx);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
                Ds_NhaSX();
            }
        }

        private void ViewNSX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
