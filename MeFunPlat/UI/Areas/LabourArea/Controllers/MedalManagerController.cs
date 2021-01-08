using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;
using Newtonsoft.Json;
using UI.Filter;

namespace UI.Areas.LabourArea.Controllers
{
    public class MedalManagerController : Controller
    {
        // GET: LabourArea/MedalManager
        public ActionResult Index()
        {
            return View();
        }

        #region 查询方法
        public ActionResult MedalDate()
        {
            List<Medal> mlist = new List<Medal>();
            using (MyContext db = new MyContext())
            {
                mlist = db.Medal.ToList();
            }
            var data = new
            {
                count = mlist.Count(),
                code = 0,
                data = mlist,
                msg = "a"
            };
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 删除方法
        public ActionResult Delete(Medal minfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                Medal mdinfo = db.Medal.Where(x => x.ID == minfo.ID).FirstOrDefault();
                db.Medal.Remove(mdinfo);
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
                return Content(result);
            }
        }
        #endregion

        #region 添加页面
        public ActionResult MedalAdd()
        {
            return View();
        }
        #endregion

        #region 添加方法
        public ActionResult MAdd(Medal minfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                db.Medal.Add(minfo);
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion

        #region 修改页面
        public ActionResult Edit(int? id)
        {
            Medal minfo = new Medal();
            using (MyContext db = new MyContext())
            {
                minfo = db.Medal.Where(x => x.ID == x.ID).FirstOrDefault();
            }
            return View(minfo);
        }
        #endregion

        #region 修改方法
        public ActionResult MedalEdit(Medal minfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                Medal mdinfo = db.Medal.Where(x => x.ID == minfo.ID).FirstOrDefault();
                mdinfo.ID = minfo.ID;
                mdinfo.MedalName = minfo.MedalName;
                mdinfo.Remake = minfo.Remake;
                mdinfo.MedalLevel = minfo.MedalLevel;
                mdinfo.State = minfo.State;
                int r = db.SaveChanges();
                if (r > 0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion
    }
}