using MVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AdminPanelController : Controller
    {
        DataClassDataContext DataBase = new DataClassDataContext();

        // GET: AdminPanel
        public ActionResult Index()
        {
            try
            {
            var dt = SQL.Execute($@"select * from AdminInfo where CONVERT(VARCHAR(32), HashBytes('MD5', concat('NaN' , AdminId , 'NaN')), 2) = '{Request.Cookies["Admins"].Values["UserId"]}'");
                
                if (dt.Rows.Count == 1)
                {
                    ViewBag.LoginnedUser = dt.Rows[0][1];
                    return View();
                }
            }
            catch (Exception)
            {
                return RedirectToAction("../Login/Index");
            }
            return RedirectToAction("../Login/Index");
        }


        public ActionResult Store()
        {
            try
            {
                var dt = SQL.Execute($@"select * from AdminInfo where CONVERT(VARCHAR(32), HashBytes('MD5', concat('NaN' , AdminId , 'NaN')), 2) = '{Request.Cookies["Admins"].Values["UserId"]}'");

                if (dt.Rows.Count == 1)
                {
                    ViewBag.LoginnedUser = dt.Rows[0][1];
                    List<Mehsullar> mehsul = new List<Mehsullar>();
                    mehsul = DataBase.Mehsullars.ToList();
                    return View(mehsul);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("../Login/Index");
            }
            return RedirectToAction("../Login/Index");
            
        }

        [HttpPost]
        public ActionResult Store(Mehsullar mehsul, HttpPostedFileBase MehsulShekil)
        {
            if (mehsul.MehsulId == 0)
            {
                string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(MehsulShekil.FileName);
                MehsulShekil.SaveAs(Server.MapPath("~/assets/images/Mehsullar/" + PhotoName));
                mehsul.MehsulShekil = PhotoName;
                DataBase.Mehsullars.InsertOnSubmit(mehsul);
            }
            else
            {
                Mehsullar selectedMehsul = DataBase.Mehsullars.SingleOrDefault(x => x.MehsulId == mehsul.MehsulId);
                selectedMehsul.MehsulAd = mehsul.MehsulAd;
                selectedMehsul.MehsulQiymet = mehsul.MehsulQiymet;
                if (MehsulShekil != null)
                {
                    string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(MehsulShekil.FileName);
                    MehsulShekil.SaveAs(Server.MapPath("~/assets/images/Mehsullar/" + PhotoName));
                    selectedMehsul.MehsulShekil = PhotoName;
                }
            }

            DataBase.SubmitChanges();
            return RedirectToAction("Store");
        }

        public ActionResult DeleteRow(int id)
        {
            DataBase.Mehsullars.DeleteOnSubmit(DataBase.Mehsullars.SingleOrDefault(x => x.MehsulId == id));
            DataBase.SubmitChanges();
            return RedirectToAction("Store");
        }
    }
}