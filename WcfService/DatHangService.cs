using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.Models;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DatHangService" in both code and config file together.
    public class DatHangService : IDatHangService
    {
        WebsiteBanDtddContext db = new WebsiteBanDtddContext();
        QuanLyTonKho tonkho = new QuanLyTonKho();

        public bool DatHang(string ten, string sdt, string email, string diachi, string total, string id, List<CartItem> cart)
        {
            try
            {
                if (id != null)
                {
                    DonDH don = new DonDH()
                    {
                        Ten = ten,
                        SDT = sdt,
                        Email = email,
                        DiaChi = diachi,
                        NgayDat = DateTime.Now,
                        TongTien = int.Parse(total),
                        MaKhachHang = int.Parse(id)
                    };
                    db.DonDHs.Add(don);
                }
                else
                {
                    DonDH don = new DonDH()
                    {
                        Ten = ten,
                        SDT = sdt,
                        Email = email,
                        DiaChi = diachi,
                        NgayDat = DateTime.Now,
                        TongTien = int.Parse(total)
                    };
                    db.DonDHs.Add(don);
                }
                db.SaveChanges();

                foreach (var item in cart)
                {
                    CT_DonDH ct = new CT_DonDH()
                    {
                        MaDonDH = db.DonDHs.Max(x => x.MaDonDH),
                        SP_ID = item.Product.SP_ID,
                        DonGiaDat = (int)item.Product.DonGia,
                        SoLuongDat = item.Quantity
                    };
                    db.CT_DonDH.Add(ct);

                    TonKho ton = new TonKho()
                    {
                        SP_ID = item.Product.SP_ID,
                        ThoiGian = DateTime.Now,
                        SoLuongTon = tonkho.TimTheoSPID(item.Product.SP_ID).SoLuongTon - item.Quantity
                    };
                    db.TonKhoes.Add(ton);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<object> History(int id)
        {
            List<object> list = new List<object>();

            return list;
        }
    }
}
