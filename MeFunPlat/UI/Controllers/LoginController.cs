using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckLogin(string username,string userpwd)
        {
            string result = "fail";
            using (MyContext content = new MyContext())
            {
                Users info = content.Users.Where(x => x.UserName == username && x.UserPwd == userpwd && x.State == 0).FirstOrDefault();
                if (info != null)
                {
                    //添加cookie
                    HttpCookie cookie = new HttpCookie("userid", info.ID.ToString());
                    cookie.Expires = DateTime.Now.AddMinutes(30);
                    Response.Cookies.Add(cookie);
                    result = "success";
                }
            }
            return Content(result);
        }

    }
}