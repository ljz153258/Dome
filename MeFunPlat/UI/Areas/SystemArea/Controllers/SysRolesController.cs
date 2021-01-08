using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;
using UI.Filter;
using Newtonsoft.Json;

namespace UI.Areas.SystemArea.Controllers
{
    public class SysRolesController : Controller
    {
        // GET: SystemArea/SysRoles
        public ActionResult Index()
        {
            return View();
        }

        #region 查询方法
        public ActionResult GetData()
        {
            string JsonStr = "{\"code\": 0,\"msg\": \"\",\"count\": 1000,\"data\": ";
            List<SysRoles> syslist = new List<SysRoles>();
            using (MyContext contxt = new MyContext())
            {
                syslist = contxt.SysRoles.Where(x => x.RoleState == 0).ToList();
            }
            string StrJson = JsonConvert.SerializeObject(syslist);
            JsonStr += StrJson + "}";

            return Content(JsonStr);
        }
        #endregion

        #region 添加视图
        public ActionResult add()
        {
            return View();
        }
        #endregion

        #region 添加方法
        public ActionResult addRoles(SysRoles info)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                db.SysRoles.Add(info);
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion

        #region 删除方法
        public ActionResult DelRoles(SysRoles info)
        {
            string result = "Fail";
            using (MyContext db = new MyContext())
            {
                SysRoles srinfo = db.SysRoles.Where(x => x.RoleID == info.RoleID).FirstOrDefault();
                db.SysRoles.Remove(srinfo);
                int r = db.SaveChanges();
                if (r>0)
                {
                    result = "Success";
                }
            }
            return Content(result);
        }
        #endregion

        #region 修改视图
        public ActionResult Edit(int ID)
        {
            using (MyContext context = new MyContext())
            {
                SysRoles sys = context.SysRoles.Where(x => x.RoleID == ID).FirstOrDefault();
                if (sys!=null)
                {
                    ViewBag.sysroles = sys;
                }
            }
            return View();
        }
        #endregion

        #region 修改方法
        public ActionResult EditRoles(SysRoles sys)
        {
            int i = 0;
            using (MyContext context = new MyContext())
            {
                SysRoles sysr = context.SysRoles.Where(x => x.RoleID == sys.RoleID).FirstOrDefault();
                sysr.RoleName = sys.RoleName;
                sysr.RoleDesc = sys.RoleDesc;
                sysr.RoleState = sys.RoleState;
                i = context.SaveChanges();
            }
            return Content(i.ToString());
        }

        #endregion
    }
}