using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.SanPhamServiceReference;
using WebWCF.QuanLyUserServiceReference;

namespace Service.Controllers
{
    public class HomeController : Controller
    {
        SanPhamServiceClient sanPhamSv = new SanPhamServiceClient();
        // GET: Home

        public ActionResult Index()
        {
            return View(sanPhamSv.ShowListProduct());
        }

        public ActionResult Contract()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Session["page"] = "Detail/"+id;
            Session["controller"] = "Home";
                return View(sanPhamSv.FindByID(id));
            

        }
       

        public ActionResult Search(string name)
        {
            return View(sanPhamSv.FindByName(name));
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(string username, string password)
        //{
        //    if (userSv.Login(username,password) > 0)
        //    {
        //        Session["LogedName"] = username;
        //    }
        //    else
        //    {
        //        Session["LogedID"] = null;
        //    }
        //    return RedirectToAction("Index");
        //}

        public ActionResult Type(string nhaSxId)
        {
            return View(sanPhamSv.FindByManu(nhaSxId));
        }
    }
}