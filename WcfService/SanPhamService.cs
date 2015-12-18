using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SanPhamService" in both code and config file together.
    public class SanPhamService : ISanPhamService
    {
        private WebsiteBanDtddContext db = new WebsiteBanDtddContext();

        public List<SanPham> DsSanPham()
        {

            List<SanPham> list = new List<SanPham>();
            var sanpham = db.Database.SqlQuery<SanPham>("Select * from SanPham").ToList();
            foreach (var item in sanpham)
            {
                SanPham sp = new SanPham()
                {
                    SP_ID = item.SP_ID,
                    TenSP = item.TenSP,
                    NhaSX_ID = item.NhaSX_ID,
                    DonGia = item.DonGia,
                    Hinh = item.Hinh,
                    CPU = item.CPU,
                    Manhinh = item.Manhinh,
                    Pin = item.Pin,
                    RAM = item.RAM,
                };
                list.Add(sp);
            }
            return list;
        }

        public bool SuaSanPham(int id, SanPham sp)
        {
            try
            {
                var res = db.SanPhams.Find(id);
                res.TenSP = sp.TenSP;
                res.NhaSX_ID = sp.NhaSX_ID;
                res.Manhinh = sp.Manhinh;
                res.RAM = sp.RAM;
                res.CPU = sp.CPU;
                res.Pin = sp.Pin;
                res.DonGia = sp.DonGia;
                res.Hinh = sp.Hinh;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ThemSanPham(SanPham sp)
        {
            try
            {
                SanPham sanpham = new SanPham()
                {
                    TenSP = sp.TenSP,
                    NhaSX_ID = sp.NhaSX_ID,
                    Manhinh = sp.Manhinh,
                    RAM = sp.RAM,
                    CPU = sp.CPU,
                    Pin = sp.Pin,
                    DonGia = sp.DonGia,
                    Hinh = sp.Hinh
                };
                db.SanPhams.Add(sanpham);
                db.SaveChanges();
                return sp.SP_ID;
            }
            catch
            {
                return 0;
            }
        }

        public SanPham TimTheoId(int id)
        {
            var sanpham = db.SanPhams.Where(x => x.SP_ID == id).FirstOrDefault();
            SanPham sp = new SanPham()
            {
                SP_ID = sanpham.SP_ID,
                TenSP = sanpham.TenSP,
                Manhinh = sanpham.Manhinh,
                RAM = sanpham.RAM,
                CPU = sanpham.CPU,
                NhaSX_ID = sanpham.NhaSX_ID,
                Pin = sanpham.Pin,
                Hinh = sanpham.Hinh,
                DonGia = sanpham.DonGia,
            };
            return sp;
        }

        public List<SanPham> TimTheoNhaSX(string nhaSx)
        {
            List<SanPham> list = new List<SanPham>();
            var sanpham = db.SanPhams.Where(x => x.NhaSX.TenNhaSX.Equals(nhaSx)).ToList();
            foreach (var item in sanpham)
            {
                SanPham sp = new SanPham()
                {
                    SP_ID = item.SP_ID,
                    TenSP = item.TenSP,
                    NhaSX_ID = item.NhaSX_ID,
                    DonGia = item.DonGia,
                    Hinh = item.Hinh,
                    CPU = item.CPU,
                    Manhinh = item.Manhinh,
                    Pin = item.Pin,
                    RAM = item.RAM,
                };
                list.Add(sp);
            }
            return list;
        }

        public List<SanPham> TimTheoTen(string ten_sp)
        {
            List<SanPham> list = new List<SanPham>();
            var sanpham = db.Database.SqlQuery<SanPham>("Select * from SanPham where TenSP like N'%" + ten_sp + "%'").ToList();
            foreach (var item in sanpham)
            {
                SanPham sp = new SanPham()
                {
                    SP_ID = item.SP_ID,
                    TenSP = item.TenSP,
                    Manhinh = item.Manhinh,
                    RAM = item.RAM,
                    CPU = item.CPU,
                    NhaSX_ID = item.NhaSX_ID,
                    Pin = item.Pin,
                    Hinh = item.Hinh,
                    DonGia = item.DonGia,
                };
                list.Add(sp);
            }
            return list;
        }

        public bool XoaSanPham(int id)
        {
            try
            {
                var res = db.SanPhams.Find(id);
                db.SanPhams.Remove(res);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
