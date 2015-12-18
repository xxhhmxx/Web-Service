using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.QuanLyUserServiceReference;

namespace Winform
{
    public partial class QuanLyKhachHang : Form
    {
        QuanLyUserServiceClient user = new QuanLyUserServiceClient();
        KhachHang kh = new KhachHang();
        public QuanLyKhachHang()
        {
            InitializeComponent();
            Ds_KhachHang();
            txtMaKhachHang.Enabled = false;

        }

        public void Ds_KhachHang()
        {
            ViewKhachHang.DataSource = user.ListUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = ViewKhachHang.CurrentRow.Index;
            List<KhachHang> list = user.ListUser().ToList();
            kh = list[vitri];
            txtMaKhachHang.Text = kh.MaKhachHang.ToString();
            txtTenKhachHang.Text = kh.Ten;
            txtDiaChi.Text = kh.DiaChi;
            txtSDT.Text = kh.SoDienThoai;
            txtEmail.Text = kh.Email;
            txtTaiKhoan.Text = kh.TenDangNhap;
            txtMatKhau.Text = kh.MatKhau;
            cbPhanQuyen.SelectedItem = kh.PerId.ToString();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            Ds_KhachHang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
            kh.Ten = txtTenKhachHang.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai= txtSDT.Text;
            kh.Email= txtEmail.Text;
            kh.TenDangNhap= txtTaiKhoan.Text;
            kh.MatKhau=txtMatKhau.Text;
            kh.PerId = int.Parse(cbPhanQuyen.SelectedItem.ToString());
            user.AddUser(kh);
            Ds_KhachHang();
            xoaform();
        }

        private void btXoaForm_Click(object sender, EventArgs e)
        {
            xoaform();
        }

        public void xoaform()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbPhanQuyen.SelectedItem = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
            kh.Ten = txtTenKhachHang.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSDT.Text;
            kh.Email = txtEmail.Text;
            kh.TenDangNhap = txtTaiKhoan.Text;
            kh.MatKhau = txtMatKhau.Text;
            kh.PerId = int.Parse(cbPhanQuyen.SelectedItem.ToString());
            user.UpdateUser(int.Parse(txtMaKhachHang.Text),kh);
            Ds_KhachHang();
            xoaform();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            ViewKhachHang.DataSource = user.FindByName(txtTenKhachHang.Text);
        }
    }
}
