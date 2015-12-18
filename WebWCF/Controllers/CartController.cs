using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.MailServiceReference;
using WebWCF.QuanLyDatHangService;
using WebWCF.QuanLyUserServiceReference;
using WebWCF.SanPhamServiceReference;

namespace Service.Controllers
{
    public class CartController : Controller
    {
        SanPhamServiceClient sanphamSv = new SanPhamServiceClient();
        QuanLyUserServiceClient userSv = new QuanLyUserServiceClient();
        DatHangServiceClient dathangSer = new DatHangServiceClient();
        MailServiceClient mail = new MailServiceClient();
        CartItem cartItem = new CartItem();

        public ActionResult AddItem(int productId, int quantity)
        {
            var sanpham = sanphamSv.FindByID(productId);
            WebWCF.QuanLyDatHangService.SanPham sp = new WebWCF.QuanLyDatHangService.SanPham()
            {
                SP_ID = productId,
                TenSP = sanpham.TenSP,
                Manhinh = sanpham.Manhinh,
                CPU = sanpham.CPU,
                DonGia = sanpham.DonGia,
                NhaSX_ID = sanpham.NhaSX_ID,
                Pin = sanpham.Pin,
                RAM = sanpham.RAM,
                Hinh = sanpham.Hinh
            };
            var cart = Session["CartItem"];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.SP_ID == productId))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.SP_ID == productId)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = sp;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                Session["CartItem"] = list;
            }
            else
            {
                var item = new CartItem();
                item.Product = sp;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);
                Session["CartItem"] = list;
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult CheckOut()
        {
            Session["page"] = "CheckOut";
            Session["controller"] = "Cart";
            if (Session["LogedName"] != null)
            {
                string t = Session["LogedName"].ToString();
                return View(userSv.FindByUsername(t));
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CheckOut(string ten, string sdt, string email, string diachi, string total)
        {
            string id = null;
            if (Session["LogedName"] != null)
            {
                string t = Session["LogedName"].ToString();
                id = userSv.FindByUsername(t).MaKhachHang.ToString();
            }
            var list = (List<CartItem>)Session["CartItem"];           
            //string date = (DateTime.Now).ToString("yyyy-mm-dd");
            if (list != null)
            {
                bool check = dathangSer.CartService(ten, sdt, email, diachi, total, id, list);
                if(check)
                {
                    string content = System.IO.File.ReadAllText(Server.MapPath("~/Asset/neworder.html"));
                    content = content.Replace("{{CustomerName}}", ten);
                    content = content.Replace("{{Phone}}", sdt);
                    content = content.Replace("{{Email}}", email);
                    content = content.Replace("{{Address}}", diachi);
                    content = content.Replace("{{Total}}", total);
                    //var toEmail = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();
                    mail.SendMail(email,"Đơn hàng từ Cửa hàng điện thoại trực tuyến: ", content);
                    //mail.SendMail(toEmail, "Đơn hàng từ Cửa hàng điện thoại trực tuyến: ", content);

                    Session["CartItem"] = null;
                    return RedirectToAction("Index", "Home");
                }               
            }
            return RedirectToAction("CheckOut");
        }
    }
}