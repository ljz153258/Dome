using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;
using UI.Filter;
using Newtonsoft.Json;

namespace UI.Areas.AreaArea.Controllers
{
    public class AreaManagerController : Controller
    {
        // GET: AreaArea/AreaManager
        public ActionResult Index()
        {
            return View();
        }
        #region 查询方法
        public ActionResult ARData()
        {
            #region 方法一
            //string jsonstr = "{\"code\": 0,\"msg\": \"\",\"count\": 1000,\"data\": ";
            //List<Area> arlist = new List<Area>();
            //using (MyContext context = new MyContext())
            //{
            //    arlist = context.Area.Where(x => x.ARState == 1).ToList();
            //}
            //string strjson = JsonConvert.SerializeObject(arlist);
            //jsonstr += strjson + "}";
            //    return Content(jsonstr);
            #endregion

            List<Area> alist = new List<Area>();
            using (MyContext db = new MyContext())
            {
                alist = db.Area.ToList();
            }
            var data = new
            {
                count = alist.Count(),
                code = 0,
                data=alist,
                msg="a"
            };
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 删除
        public ActionResult Delete(Area arinfo)
        {
            string result = "File";
            using (MyContext db = new MyContext())
            {
                Area ainfo = db.Area.Where(x => x.ARID == arinfo.ARID).FirstOrDefault();
                db.Area.Remove(ainfo);
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion

        #region 添加页面
        public ActionResult Add()
        {
            return View();
        }

        #endregion

        #region 添加方法
        public ActionResult AddArea(Area arinfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                db.Area.Add(arinfo);
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
            Area arinfo = new Area();
            using (MyContext db = new MyContext())
            {
                arinfo = db.Area.Where(x => x.ARID == id).FirstOrDefault();
            }
            return View(arinfo);
        }

        #endregion

        #region 修改方法
        public ActionResult EditArea(Area arinfo)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                Area areas = db.Area.Where(x=>x.ARID == arinfo.ARID).FirstOrDefault();
                areas.ARName = arinfo.ARName;
                areas.ARParent = arinfo.ARParent;
                areas.ARIndex = arinfo.ARIndex;
                areas.ARState = arinfo.ARState;
                areas.ARReamle = arinfo.ARReamle;
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion
    }
}