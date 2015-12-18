using Facebook;
using Service.Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.QuanLyUserServiceReference;

namespace Service.Controllers
{
    public class UserController : Controller
    {
        private Uri RedirectUri
        {
            get
            {
                var uriBuilder = new UriBuilder(Request.Url);
                uriBuilder.Query = null;
                uriBuilder.Fragment = null;
                uriBuilder.Path = Url.Action("FacebookCallback");
                return uriBuilder.Uri;
            }
        }
        QuanLyUserServiceClient khachHang = new QuanLyUserServiceClient();
        // GET: User
        public ActionResult Index()
        {
           
                if (Session["LogedName"] == null)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string username, string password)
        {
            try
            {
                if (Session["page"] == null)
                {
                    if (khachHang.Login(username, password) > 0)
                    {
                        Session["LogedName"] = username;
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    string t = Session["page"].ToString();
                    string t1 = Session["controller"].ToString();
                    if (khachHang.Login(username, password) > 0)
                    {
                        Session["LogedName"] = username;
                        Session["page"] = null;
                        return RedirectToAction(t, t1);
                    }
                    return RedirectToAction("Index", "User");


                //    if (Session["page"].ToString().Equals("/Cart/CheckOut"))
                //{
                //    if (khachHang.Login(username, password) > 0)
                //    {
                //        Session["LogedName"] = username;
                //        Session["page"] = null;
                //        return RedirectToAction("CheckOut", "Cart");
                //    }
                //    return RedirectToAction("Index", "User");
                //}
                //if (Session["page"].ToString().CompareTo("Detail") > 0)
                //{
                //    string t = Session["page"].ToString();
                //    if (khachHang.Login(username, password) > 0)
                //    {
                //        Session["LogedName"] = username;
                //        Session["page"] = null;
                //        return RedirectToAction(t, "Home");
                //    }
                //    return RedirectToAction("Index", "User");
                //}

            }
                return RedirectToAction("Index", "User");
            }
            catch
            {
                return RedirectToAction("Index", "User");
            }
        }

        public ActionResult Register()
        {
            if (Session["LogedName"] == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult Register(KhachHang kh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string pass = Helper.Encryptor.MD5Hash(kh.MatKhau);
                    kh.PerId = 1;
                    kh.MatKhau = pass;
                    bool i = khachHang.AddUser(kh);
                    if (i)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }
                return View(kh);
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Edit(int id)
        {
            return View(khachHang.FindById(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, KhachHang kh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool i = khachHang.UpdateUser(id, kh);
                    if (i)
                    {
                        return RedirectToAction("Detail", "User");
                    }

                }
                return View(kh);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail()
        {
            string ten = Session["LogedName"].ToString();
            return View(khachHang.FindByUsername(ten));
        }

        public ActionResult Logout()
        {
            try
            {
                Session["LogedName"] = null;
                Session["CartPage"] = null;
                return RedirectToAction("Index", "Home");
            }
            catch
            {

                Session["CartPage"] = null;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult LoginFacebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = ConfigurationManager.AppSettings["LoginId"],
                client_secret = ConfigurationManager.AppSettings["LoginSec"],
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email",
            });
            return Redirect(loginUrl.AbsoluteUri);
        }
        public ActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = ConfigurationManager.AppSettings["LoginId"],
                client_secret = ConfigurationManager.AppSettings["LoginSec"],
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });

            var access_token = result.access_token;
            if (!string.IsNullOrEmpty(access_token))
            {
                fb.AccessToken = access_token;
                dynamic me = fb.Get("me?fields=first_name,middle_name,last_name,id,email");
                string email = me.email;
                string username = me.email;
                string firstname = me.first_name;
                string middlename = me.middle_name;
                string lastname = me.last_name;

                var kh = new KhachHang();
                kh.Email = email;
                kh.TenDangNhap = username;
                kh.MatKhau = "123";
                kh.Ten = lastname + middlename + firstname;
                kh.PerId = 1;
                kh.SoDienThoai = "";
                kh.DiaChi = "";
                Session["LogedName"] = username;
                var check = khachHang.AddUserForFacebook(kh);
            }
            return RedirectToAction("Index", "Home");
        }


    }
}