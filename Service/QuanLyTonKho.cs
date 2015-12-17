using Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuanLyTonKho" in both code and config file together.
    public class QuanLyTonKho : IQuanLyTonKho
    {
        private WebsiteBanDtddContext db = new WebsiteBanDtddContext();

        public List<TonKho> HienThiTonKho()
        {
            List<TonKho> data = new List<TonKho>();
            string sql = "select sp.SP_ID,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                        + " (select max(thoigian) from TonKho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {

                        SP_ID = int.Parse(rd[0].ToString()),
                        //TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[1].ToString()),
                        ThoiGian = DateTime.Parse(rd[2].ToString())
                    };
                    data.Add(tk);
                }
            }
            return data;


        }

        public List<TonKho> TimKiemTonKho_SPID(TonKho tk)
        {
            List<TonKho> data = new List<TonKho>();
            string sql = "select sp.SP_ID,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and tk.SP_ID=@SP_ID and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlParameter sp_id = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, sp_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        // TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[1].ToString()),
                        ThoiGian = DateTime.Parse(rd[2].ToString())
                    };
                    data.Add(tk);
                }
            }
            return data;
        }

        // Hàm tự viết
        // Tìm kiếm tồn kho theo thời gian (năm - tháng)


        // Hàm tự viết
        // Tìm kiếm tồn kho theo khoảng thời gian
        public List<TonKho> TimKiemTonKho_Ngay(DateTime ngaytu, DateTime ngayden)
        {
            List<TonKho> data = new List<TonKho>();
            string sql = "select sp.SP_ID,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and (ThoiGian >=@NgayTu and ThoiGian<=@NgayDen) and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlParameter ngay_tu = new SqlParameter("@NgayTu", ngaytu);
            SqlParameter ngay_den = new SqlParameter("@NgayDen", ngayden.AddDays(1));
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, ngay_tu, ngay_den);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        //TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[1].ToString()),
                        ThoiGian = DateTime.Parse(rd[2].ToString())
                    };
                    data.Add(tk);
                }
            }
            return data;
        }

        // Hàm tự viết
        // Tìm kiếm tồn kho theo số lượng tồn
        // k: so luong ton tang - giam
        public List<TonKho> TimKiemTonKho_SoLuongTon(int k)
        {
            List<TonKho> data = new List<TonKho>();
            string sql = "";
            if (k == 0)
            {
                sql = "select sp.SP_ID,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                            + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                            + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SoLuongTon desc";
            }
            else
            {
                sql = "select sp.SP_ID,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                            + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                            + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SoLuongTon";
            }
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        //TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[1].ToString()),
                        ThoiGian = DateTime.Parse(rd[2].ToString())
                    };
                    data.Add(tk);
                }
            }
            return data;
        }

        // Hàm tự viết
        // Thêm mới 1 sản phẩm vào tồn kho
        public void Them_Moi(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian, @SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }

        // Hàm tự viết
        // Nhập kho
        public void Them_Nhap(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian,(select top 1 SoLuongTon from TonKho where SP_ID=@SP_ID order by ThoiGian desc)+@SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }

        // Hàm tự viết
        // Xuất kho
        public void Them_Xuat(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian,(select top 1 SoLuongTon from TonKho where SP_ID=@SP_ID order by ThoiGian desc)-@SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }

        // Hàm tự viết
        // Xóa sản phẩm
        public void Xoa(TonKho tk)
        {
            string sql = "Delete TonKho where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid);
        }

        public TonKho TimTheoSPID(int id)
        {
            try
            {
                var tonkho = db.TonKhoes.Where(x => x.SP_ID == id).ToList();
                List<TonKho> ton = new List<TonKho>();
                foreach (var i in tonkho)
                {
                    TonKho t = new TonKho()
                    {
                        SP_ID = i.SP_ID,
                        ThoiGian = i.ThoiGian,
                        SoLuongTon = i.SoLuongTon
                    };
                    ton.Add(t);
                }
                return ton.Last();
            }
            catch
            {
                return null;
            }
        }
    }
}
