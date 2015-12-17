using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Winform.CT_DHServiceReference;
using Winform.QuanLyTonKhoServiceReference;
using Winform.QuanLyDonHangServiceReference;

namespace WinForm
{
    public partial class FrmQuanLyDonHang : Form
    {
        QuanLyDonHangClient qldh = new QuanLyDonHangClient();
        Winform.QuanLyDonHangServiceReference.DonDH ddh = new Winform.QuanLyDonHangServiceReference.DonDH();
        CT_DHServiceClient ctdh = new CT_DHServiceClient();
        Winform.QuanLyTonKhoServiceReference.TonKho tk = new Winform.QuanLyTonKhoServiceReference.TonKho();
        Winform.CT_DHServiceReference.CT_DonDH ct = new Winform.CT_DHServiceReference.CT_DonDH();
        QuanLyTonKhoClient qltk = new QuanLyTonKhoClient();
        public FrmQuanLyDonHang()
        {
            InitializeComponent();
            HienThiDonHang();
            gbThongTin.Enabled = false;
            frm();
            //HienThiCT_DonHang(ct);
        }
        public void HienThiDonHang()
        {
            ViewDonHang.DataSource = qldh.HienThiDonDH();
            

        }
        public void HienThiCT_DonHang(Winform.CT_DHServiceReference.CT_DonDH ct)
        {
            ViewCT_DH.DataSource = ctdh.HienThiCT_DonDH(ct);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTim.Text == "Mã Đơn Hàng")
            {
                if (txtMaDonHang.Text != "")
                {
                    ViewDonHang.AutoGenerateColumns = false;
                    ViewDonHang.DataSource = qldh.TimKiem_MaDH(txtMaDonHang.Text);
                }
                else
                {
                    MessageBox.Show("Nhập mã đơn đặt hàng");
                }
            }
            else if (cbTim.Text == "Ngày Đặt")
            {
                ViewDonHang.AutoGenerateColumns = false;
                ViewDonHang.DataSource = qldh.TimKiem_NgayDat(dtNgayDat.Value);
            }
            else
            {
                ViewDonHang.AutoGenerateColumns = false;
                string tt = cbTinhTrang.SelectedItem.ToString();
                ViewDonHang.DataSource = qldh.TimKiem_TinhTrang(tt);
            }
        }

        private void btnCapNhatDH_Click(object sender, EventArgs e)
        {
            ViewDonHang.DataSource = qldh.HienThiDonDH();
        }

        private void btnSua_DH_Click(object sender, EventArgs e)
        {
            try
            {
                int madondh = int.Parse(ViewDonHang.CurrentRow.Cells[0].Value.ToString());
                string tinhtrang = cbTinhTrang_Sua.SelectedItem.ToString();
                int tongtien = int.Parse(txtTongTien.Text);
                ddh.MaDonDH = madondh;
                ddh.TinhTrang = tinhtrang;
                ddh.TongTien = tongtien;
                qldh.Sua_DH(ddh);
                HienThiDonHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void ViewDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = ViewDonHang.CurrentRow.Index;
            List<Winform.QuanLyDonHangServiceReference.DonDH> list = qldh.HienThiDonDH().ToList();
            ddh = list[vitri];
            txtTenKhachHang.Text = ddh.Ten;
            txtDiaChi.Text = ddh.DiaChi;
            txtDienThoai.Text = ddh.SDT;
            txtEmail.Text = ddh.Email;
            txtTongTien.Text = ddh.TongTien.ToString();
            cbTinhTrang_Sua.SelectedItem = ddh.TinhTrang;
            int madondh = int.Parse(ViewDonHang.CurrentRow.Cells[0].Value.ToString());
            ct.MaDonDH = madondh;
            HienThiCT_DonHang(ct);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiCT_DonHang(ct);
        }

        public void TimKiemTheo()
        {
            
        }

        public void frm()
        {
            txtMaDonHang.Enabled = false;
            cbTinhTrang.Enabled = false;
            dtNgayDat.Enabled = false;
        }

        private void cbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTim.Text == "Mã Đơn Hàng")
            {
                txtMaDonHang.Enabled = true;
                cbTinhTrang.Enabled = false;
                dtNgayDat.Enabled = false;
            }
            else if (cbTim.Text == "Ngày Đặt")
            {
                txtMaDonHang.Enabled = false;
                cbTinhTrang.Enabled = false;
                dtNgayDat.Enabled = true;
            }
            else
            {
                txtMaDonHang.Enabled = false;
                cbTinhTrang.Enabled = true;
                dtNgayDat.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("yyyyMMddhhmmss");
            if (MessageBox.Show("Chương trình sẽ xóa đơn đặt hàng và chi tiết ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    // lay ma don dh
                    ct.MaDonDH = int.Parse(ViewDonHang.CurrentRow.Cells[0].Value.ToString());

                    // cap nhat ton kho
                    List<Winform.CT_DHServiceReference.CT_DonDH> list_ct = ctdh.HienThiCT_DonDH(ct).ToList();
                    for (int i = 0; i < list_ct.Count; i++)
                    {
                        ct = list_ct[i];
                        tk.SP_ID = ct.SP_ID;
                        tk.ThoiGian = DateTime.Now;
                        tk.SoLuongTon = ct.SoLuongDat;
                        qltk.Them_Moi(tk);
                    }

                    // xoa chi tiet
                    //bll_ctdondh.MaDonDH = dgvDonDH.CurrentRow.Cells[1].Value.ToString();
                    ctdh.Xoa(ct);

                    // xoa don dat hang
                    ddh.MaDonDH = int.Parse(ViewDonHang.CurrentRow.Cells[0].Value.ToString());
                    qldh.Xoa(ddh);


                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
                HienThiDonHang();
                ViewCT_DH.AutoGenerateColumns = false;
                ViewCT_DH.DataSource = null;
            }
        }
    }
}
