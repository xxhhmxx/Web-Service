using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.SanPhamServiceReference;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;

namespace WinForm
{
    public partial class FrmSanPham : Form
    {
        SanPhamServiceClient sp = new SanPhamServiceClient();
        Winform.QuanLyNhaSXServiceReference.QuanLyNhaSxServiceClient nhasx = new Winform.QuanLyNhaSXServiceReference.QuanLyNhaSxServiceClient();
        private string name;

        public FrmSanPham()
        {
            InitializeComponent();
            Ds_SanPham();
            var list = nhasx.HienThiNhaSX();
            foreach(var item in list)
            {
                comboBox1.Items.Add(item.TenNhaSX);
            }
        }

        public void TimTheoTen(string name)
        {
            viewSP.DataSource = sp.FindByName(name);
        }

        public void Ds_SanPham()
        {
            viewSP.DataSource = sp.ShowListProduct();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void sanPhamBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void viewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sanpham = new SanPham();
            int vitri = viewSP.CurrentRow.Index;
            List<SanPham> list = sp.ShowListProduct();
            sanpham = list[vitri];
            txtMaSanPham.Text = sanpham.SP_ID.ToString();
            txtTenSanPham.Text = sanpham.TenSP.ToString();
            txtManHinh.Text = sanpham.Manhinh.ToString();
            txtRam.Text = sanpham.RAM.ToString();
            textCPU.Text = sanpham.CPU.ToString();
            txtDonGia.Text = sanpham.DonGia.ToString();
            comboBox1.SelectedIndex = (int)sanpham.NhaSX_ID-1;
            txtPin.Text = sanpham.Pin.ToString();

            //  "../../../WebWCF/~/Asset/images/"
            if (!viewSP.CurrentRow.Cells[8].Value.ToString().Equals(null))
            {
                string name = viewSP.CurrentRow.Cells[8].Value.ToString();
                string duongdan = name.Replace("~", "../../../WebWCF");
                txtHinh.Text = name;
                Hinh.Load(duongdan);
                Hinh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                Hinh.Load("../../../WebWCF/WebWCF/Asset/images/error.jpg");
                Hinh.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            Ds_SanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham()
            {
                TenSP = txtTenSanPham.Text,
                NhaSX_ID = comboBox1.SelectedIndex+1,
                Manhinh = txtManHinh.Text,
                RAM = txtRam.Text,
                CPU = textCPU.Text,
                DonGia = int.Parse(txtDonGia.Text),
                Pin = txtPin.Text,
                Hinh = txtHinh.Text,
            };
            sp.AddProduct(sanpham);
            Ds_SanPham();
            Xoaform();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            sanpham.TenSP = txtTenSanPham.Text;
            sanpham.Manhinh = txtManHinh.Text;
            sanpham.RAM = txtRam.Text;
            sanpham.CPU = textCPU.Text;
            sanpham.Pin = txtPin.Text;
            sanpham.NhaSX_ID = comboBox1.SelectedIndex+1;
            sanpham.DonGia = int.Parse(txtDonGia.Text);
            sanpham.Hinh = null;
            sp.UpdateProduct(int.Parse(txtMaSanPham.Text), sanpham);
            Ds_SanPham();
            Xoaform();
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            Xoaform();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimTheoTen(txtTenSanPham.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Hinh.Load(f.FileName);
                name = f.SafeFileName;
                string duongdanmoi = "../../../WebWCF/Asset/images/" + name;
                File.Copy(f.FileName, duongdanmoi);
                MessageBox.Show(name);
                duongdanmoi = duongdanmoi.Replace("../../../WebWCF", "~");
                txtHinh.Text = duongdanmoi;
            }
        }

        public void Xoaform()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtManHinh.Text = "";
            txtRam.Text = "";
            textCPU.Text = "";
            txtDonGia.Text = "";
            comboBox1.SelectedIndex = 0;
            txtPin.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewSP.DataSource = sp.FindByName(txtTenSanPham.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewSP.DataSource = sp.FindByManu(comboBox1.SelectedItem.ToString());
        }
    }
}
