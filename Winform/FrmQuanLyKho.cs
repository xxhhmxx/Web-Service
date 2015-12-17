using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.QuanLyTonKhoServiceReference;

namespace WinForm
{
    public partial class FrmQuanLyKho : Form
    {
        QuanLyTonKhoClient qltk = new QuanLyTonKhoClient();
        TonKho tk = new TonKho();
        public FrmQuanLyKho()
        {
            InitializeComponent();
            HienThi_TonKho();
            frm();
        }

        private void dtTu_ValueChanged(object sender, EventArgs e)
        {

        }
        public void HienThi_TonKho()
        {
            //ViewQuanLyKho.AutoGenerateColumns = false;
            //ViewQuanLyKho.DataSource = qltk.HienThiTonKho();
            ViewQuanLyKho.DataSource = qltk.HienThiTonKho();
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ViewQuanLyKho.DataSource = qltk.HienThiTonKho();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ViewQuanLyKho.AutoGenerateColumns = false;
                if (cbTimKiem.Text == "Mã Sản Phẩm")
                {
                    int sp_id = int.Parse(txtMaSanPham.Text);
                    tk.SP_ID = sp_id;

                    if (qltk.HienThiTonKho().Count() > 0)
                    {
                        ViewQuanLyKho.DataSource = qltk.TimKiemTonKho_SPID(tk);
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm này", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewQuanLyKho.DataSource = null;
                    }
                }
                else if (cbTimKiem.Text == "Số Lượng Tồn")
                {
                    int k = int.Parse(cbSoLuongTon.SelectedIndex.ToString());

                    if (qltk.TimKiemTonKho_SoLuongTon(k).Count() > 0)
                    {
                        ViewQuanLyKho.DataSource = qltk.TimKiemTonKho_SoLuongTon(k);
                    }
                }
                else
                {
                    ViewQuanLyKho.DataSource = qltk.TimKiemTonKho_Ngay(dtTu.Value, dtDen.Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Sản Phẩm")
            {
                txtMaSanPham.Enabled = true;
                cbSoLuongTon.Enabled = false;
                pnThoiGian.Enabled = false;
            }
            else if (cbTimKiem.Text == "Số Lượng Tồn")
            {
                txtMaSanPham.Enabled = false;
                cbSoLuongTon.Enabled = true;
                pnThoiGian.Enabled = false;
            }
            else
            {
                txtMaSanPham.Enabled = false;
                cbSoLuongTon.Enabled = false;
                pnThoiGian.Enabled = true;
            }
        }

        public void frm()
        {
            txtMaSanPham.Enabled = false;
            cbSoLuongTon.Enabled = false;
            pnThoiGian.Enabled = false;
        }
    }
}
