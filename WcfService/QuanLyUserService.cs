using Service.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuanLyUserService" in both code and config file together.
    public class QuanLyUserService : IQuanLyUserService
    {
        private WebsiteBanDtddContext db = new WebsiteBanDtddContext();

        public bool AddUser(KhachHang kh)
        {
            try
            {
                KhachHang khachhang = new KhachHang()
                {
                    Ten = kh.Ten,
                    TenDangNhap = kh.TenDangNhap,
                    MatKhau = Helper.Encryptor.MD5Hash(kh.MatKhau),
                    SoDienThoai = kh.SoDienThoai,
                    DiaChi = kh.DiaChi,
                    Email = kh.Email,
                    PerId = 1
                };
                db.KhachHangs.Add(khachhang);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<KhachHang> FindByName(string name)
        {
            var khachHang = db.Database.SqlQuery<KhachHang>("Select * from KhachHang where Ten like N'%" + name + "%'").ToList();
            List<KhachHang> list = new List<KhachHang>();
            foreach (var item in khachHang)
            {
                KhachHang kh = new KhachHang()
                {
                    Ten = item.Ten,
                    TenDangNhap = item.TenDangNhap,
                    MatKhau = item.MatKhau,
                    SoDienThoai = item.SoDienThoai,
                    DiaChi = item.DiaChi,
                    Email = item.Email,
                    PerId = item.PerId
                };
                list.Add(kh);
            }
            return list;
        }

        public KhachHang FindById(int id)
        {
            var item = db.KhachHangs.Where(x => x.MaKhachHang == id).FirstOrDefault();
            KhachHang kh = new KhachHang()
            {
                Ten = item.Ten,
                TenDangNhap = item.TenDangNhap,
                MatKhau = item.MatKhau,
                SoDienThoai = item.SoDienThoai,
                DiaChi = item.DiaChi,
                Email = item.Email,
            };
            return kh;
        }

        public List<KhachHang> ListUser()
        {
            List<KhachHang> list = new List<KhachHang>();
            var khachhang = db.Database.SqlQuery<KhachHang>("Select * from KhachHang").ToList();
            foreach (var item in khachhang)
            {
                KhachHang kh = new KhachHang()
                {
                    MaKhachHang=item.MaKhachHang,
                    Ten = item.Ten,
                    TenDangNhap = item.TenDangNhap,
                    MatKhau = item.MatKhau,
                    SoDienThoai = item.SoDienThoai,
                    DiaChi = item.DiaChi,
                    Email = item.Email,
                    PerId = item.PerId
                };
                list.Add(kh);
            }
            return list;
        }

        public int Login(string username, string password)
        {
            string tmp = Helper.Encryptor.MD5Hash(password);
            try
            {
                return db.KhachHangs.Count(x => x.TenDangNhap.Equals(username) && x.MatKhau.Equals(tmp));
            }
            catch
            {
                return 0;
            }
        }

        public bool UpdateUser(int id, KhachHang kh)
        {
            try
            {
                var item = db.KhachHangs.Find(id);
                item.Ten = kh.Ten;
                item.TenDangNhap = kh.TenDangNhap;
                if (item.MatKhau.Equals(kh.MatKhau))
                {
                    item.MatKhau = kh.MatKhau;
                }
                else
                {
                    item.MatKhau = Helper.Encryptor.MD5Hash(kh.MatKhau);
                }
                item.SoDienThoai = kh.SoDienThoai;
                item.DiaChi = kh.DiaChi;
                item.Email = kh.Email;
                item.PerId = kh.PerId;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public KhachHang FindByUsername(string username)
        {
            var item = db.Database.SqlQuery<KhachHang>("Select * from KhachHang where TenDangNhap like N'%" + username + "%'").First();
            KhachHang kh = new KhachHang()
            {
                MaKhachHang = item.MaKhachHang,
                Ten = item.Ten,
                TenDangNhap = item.TenDangNhap,
                MatKhau = item.MatKhau,
                SoDienThoai = item.SoDienThoai,
                DiaChi = item.DiaChi,
                Email = item.Email,
                PerId = item.PerId
            };
            return kh;

        }

        public bool AddUserForFacebook(KhachHang kh)
        {
            if (db.KhachHangs.Count(x => x.TenDangNhap.Equals(kh.TenDangNhap)) == 0)
            {
                KhachHang khachhang = new KhachHang()
                {
                    Ten = kh.Ten,
                    TenDangNhap = kh.TenDangNhap,
                    MatKhau = Helper.Encryptor.MD5Hash(kh.MatKhau),
                    SoDienThoai = kh.SoDienThoai,
                    DiaChi = kh.DiaChi,
                    Email = kh.Email,
                    PerId = 1
                };
                db.KhachHangs.Add(khachhang);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
