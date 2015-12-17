using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform;

namespace WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void openform(Form frm)
        {
            if (Application.OpenForms[frm.Name] == null)
            {
                //frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var sanpham = new FrmSanPham();
            openform(sanpham);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var gioithieu = new FrmGioiThieu();
            openform(gioithieu);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var phieunhap = new FrmPhieuNhap();
            openform(phieunhap);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var donhang = new FrmQuanLyDonHang();
            openform(donhang);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var tonkho = new FrmQuanLyKho();
            openform(tonkho);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var nhasanxuat = new FrmNhaSanXuat();
            openform(nhasanxuat);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            var khachhang = new QuanLyKhachHang();
            openform(khachhang);
        }
    }
}
