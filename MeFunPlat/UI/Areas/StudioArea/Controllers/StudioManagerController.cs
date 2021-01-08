using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;
using UI.Filter;
using Newtonsoft.Json;

namespace UI.Areas.StudioArea.Controllers
{
    public class StudioManagerController : Controller
    {
        // GET: StudioArea/StudioManager
        public ActionResult Index()
        {
            return View();
        }

        #region 查询方法
        public ActionResult StuDate()
        {
            List<Studio> slist = new List<Studio>();
            using (MyContext db = new MyContext())
            {
                slist = db.Studio.ToList();
            }
            var data = new
            {
                count = slist.Count(),
                code = 0,
                data = slist,
                msg = "a"
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 删除方法
        public ActionResult Delete(Studio sinfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                Studio stuinfo = db.Studio.Where(x => x.RoomID == sinfo.RoomID).FirstOrDefault();
                db.Studio.Remove(stuinfo);
                int r = db.SaveChanges();
                if (r > 0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }

        #endregion

        #region 添加页面
        public ActionResult StuAdd()
        {
            return View();
        }
        #endregion

        #region 添加方法
        public ActionResult StuAdds(Studio sinfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                db.Studio.Add(sinfo);
                int r = db.SaveChanges();
                if (r > 0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }

        #endregion

        #region 修改方法
        public ActionResult StuEdit(int? id)
        {
            Studio sinfo = new Studio();
            using (MyContext db = new MyContext())
            {
                sinfo = db.Studio.Where(x => x.RoomID == id).FirstOrDefault();
            }
            return View(sinfo);
        }

        #endregion

        #region 修改方法
        public ActionResult StuEdits(Studio sinfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                Studio stuinfo = db.Studio.Where(x => x.RoomID == sinfo.RoomID).FirstOrDefault();
                stuinfo.RoomID = sinfo.RoomID;
                stuinfo.RoomName = sinfo.RoomName;
                stuinfo.Remake = sinfo.Remake;
                stuinfo.State = sinfo.State;
                int r = db.SaveChanges();
                if (r > 0)
                {
                    result = "Success";
                }
                return Content(result);
            }
        }
        #endregion
    }
}