using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        DataClassDataContext DataBase = new DataClassDataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.List = DataBase.Contacts.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message, string name, string email)
        {
            Contact ContactInfo = new Contact();
            ContactInfo.ConMessage = message;
            ContactInfo.ConName = name;
            ContactInfo.ConMail = email;

            DataBase.Contacts.InsertOnSubmit(ContactInfo);
            DataBase.SubmitChanges();
            return RedirectToAction("Contact");
        }
        
        public ActionResult Store()
        {
            List<Mehsullar> mehsul = new List<Mehsullar>();
            mehsul = DataBase.Mehsullars.ToList();
            return View(mehsul);
        }

        public ActionResult UpcomingGames()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }
    }
}