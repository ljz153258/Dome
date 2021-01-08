using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Filter;
using WeFunModel;
using Newtonsoft.Json;
using System.IO;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [LoginFilter]
        public ActionResult Index()
        {
            //using (MyContext context = new MyContext())
            //{
            //    Users info = new Users() { ID = 1, UserName = "admin", UserPwd = "admin", NickName = "管理员", State = 0 };
            //    context.Users.Add(info);
            //    int result = context.SaveChanges();
            //}
            GetData();
            return View();
        }

        public void GetData()
        {
            string jsonStr = "{\"homeInfo\": {\"title\": \"首页\",\"href\":\"/Home/Select\"},\"logoInfo\": {\"title\": \"WeFun管理后台\",\"image\":\"/Content/images/logo.png\",\"href\": \"\"},\"menuInfo\": [{\"title\": \"常规管理\",\"icon\": \"fa fa-address-book\",\"href\": \"\",\"target\":\"_self\",\"child\": [";
            using (MyContext context = new MyContext())
            {
                //获取一级菜单
                List<SysPopedoms> fristm = context.SysPopedoms.Where(x => x.Parent == 0 && x.PopState == 1).OrderBy(x => x.PopIndex).ToList();
                foreach (SysPopedoms item in fristm)
                {
                    jsonStr += "{\"title\": \"" + item.PopName + "\",\"href\": \"\",\"target\": \"_self\",\"child\": [ ";
                    //获取第二级菜单
                    List<SysPopedoms> secondm = context.SysPopedoms.Where(x => x.Parent == item.PopID && x.PopState == 1).OrderBy(x => x.PopIndex).ToList();
                    foreach (SysPopedoms temp in secondm)
                    {
                        jsonStr += "{\"title\": \"" + temp.PopName + "\",\"href\": \"/"+temp.PopArea+"/"+temp.PopControll+"/Index"+"\",\"icon\": \"fa fa-navicon\",\"target\": \"_self\"},";
                    }
                    //去除最后一个逗号
                    jsonStr = jsonStr.Substring(0, jsonStr.Length - 1);
                    jsonStr += "]},";
                }
                //去除最后一个逗号
                jsonStr = jsonStr.Substring(0, jsonStr.Length - 1);
            }
            jsonStr += "]}]}";
            StreamWriter sw = new StreamWriter(Server.MapPath("/Content/api/init.json"));
            sw.Write(jsonStr);
            sw.Close();
        }

        public ActionResult Select()
        {
            return View();
        }

        public ActionResult ErrorMan()
        {
            return View();
        }
    }
}