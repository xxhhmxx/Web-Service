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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuanLyDonHang" in both code and config file together.
    public class QuanLyDonHang : IQuanLyDonHang
    {
        public List<DonDH> HienThiDonDH()
        {
            List<DonDH> data = new List<DonDH>();
            string sql = "select * from DonDH";
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            DonDH ddh = new DonDH();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    if (ddh.TinhTrang != "" && ddh.MaKhachHang != null)
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = DateTime.Parse(rd[6].ToString()),
                            GhiChu = rd[7].ToString(),
                            TinhTrang = rd[8].ToString(),
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = int.Parse(rd[10].ToString())
                        };

                    }
                    else
                    {
                        if (ddh.TinhTrang != "")
                        {
                            ddh = new DonDH()
                            {

                                MaDonDH = int.Parse(rd[0].ToString()),
                                Ten = rd[1].ToString(),
                                SDT = rd[2].ToString(),
                                Email = rd[3].ToString(),
                                DiaChi = rd[4].ToString(),
                                NgayDat = DateTime.Parse(rd[5].ToString()),
                                NgayGiao = null,
                                GhiChu = null,
                                TinhTrang = rd[8].ToString(),
                                TongTien = int.Parse(rd[9].ToString()),
                                MaKhachHang = null
                            };
                        }
                        else
                        {
                            ddh = new DonDH()
                            {

                                MaDonDH = int.Parse(rd[0].ToString()),
                                Ten = rd[1].ToString(),
                                SDT = rd[2].ToString(),
                                Email = rd[3].ToString(),
                                DiaChi = rd[4].ToString(),
                                NgayDat = DateTime.Parse(rd[5].ToString()),
                                NgayGiao = null,
                                GhiChu = null,
                                TinhTrang = null,
                                TongTien = int.Parse(rd[9].ToString()),
                                MaKhachHang = null
                            };
                        }
                    }


                    data.Add(ddh);
                }

            }
            return data;
        }

        public List<DonDH> TimKiem_MaDH(string madondh)
        {
            List<DonDH> data = new List<DonDH>();
            string sql = string.Format("select * from DonDH where MaDonDH='{0}'", madondh);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            DonDH ddh = new DonDH();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = DateTime.Parse(rd[6].ToString()),
                            GhiChu = rd[7].ToString(),
                            TinhTrang = rd[8].ToString(),
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = int.Parse(rd[10].ToString())
                        };
                    }
                    catch
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = null,
                            GhiChu = null,
                            TinhTrang = null,
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = null
                        };
                    }
                    data.Add(ddh);
                }

            }
            return data;
        }

        public List<DonDH> TimKiem_NgayDat(DateTime ngaydat)
        {
            List<DonDH> data = new List<DonDH>();
            string sql = string.Format("select * from DonDH where NgayDat='{0}'", ngaydat);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            DonDH ddh = new DonDH();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = DateTime.Parse(rd[6].ToString()),
                            GhiChu = rd[7].ToString(),
                            TinhTrang = rd[8].ToString(),
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = int.Parse(rd[10].ToString())
                        };
                    }
                    catch
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = null,
                            GhiChu = null,
                            TinhTrang = null,
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = null
                        };
                    }
                    data.Add(ddh);
                }
            }
            return data;
        }

        public List<DonDH> TimKiem_TinhTrang(string tinhtrang)
        {
            List<DonDH> data = new List<DonDH>();
            string sql = "select * from DonDH where TinhTrang=@TinhTrang";
            SqlParameter tinh_trang = new SqlParameter("@TinhTrang", tinhtrang);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, tinh_trang);
            DonDH ddh = new DonDH();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = DateTime.Parse(rd[6].ToString()),
                            GhiChu = rd[7].ToString(),
                            TinhTrang = rd[8].ToString(),
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = int.Parse(rd[10].ToString())
                        };
                    }
                    catch
                    {
                        ddh = new DonDH()
                        {

                            MaDonDH = int.Parse(rd[0].ToString()),
                            Ten = rd[1].ToString(),
                            SDT = rd[2].ToString(),
                            Email = rd[3].ToString(),
                            DiaChi = rd[4].ToString(),
                            NgayDat = DateTime.Parse(rd[5].ToString()),
                            NgayGiao = null,
                            GhiChu = null,
                            TinhTrang = null,
                            TongTien = int.Parse(rd[9].ToString()),
                            MaKhachHang = null
                        };
                    }
                    data.Add(ddh);
                }
            }
            return data;
        }
        
        public void Sua_DH(DonDH ddh)
        {
            string sql = "update DonDH set TinhTrang=@TinhTrang, TongTien=@TongTien where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", ddh.TinhTrang);
            SqlParameter tongtien = new SqlParameter("@TongTien", ddh.TongTien);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, madondh, tinhtrang, tongtien);
        }

        public void Xoa(DonDH ddh)
        {
            string sql = "Delete DonDH where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, madondh);
        }
    }
}
