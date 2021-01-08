using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeFunModel;
using Newtonsoft.Json;

namespace UI.Areas.SuggestionArea.Controllers
{
    public class SuggestionManagerController : Controller
    {
        // GET: SuggestionArea/SuggestionManagerv 
        public ActionResult Index()




        {
            return View();
        }

        #region 查询方法
        public ActionResult SugData()
        {
            List<Suggestion> suglist = new List<Suggestion>();
            using (MyContext db = new MyContext())
            {
                
                    suglist = db.Suggestions.ToList();
            }
            var data = new
            {
                count = suglist.Count(),
                code = 0,
                data = suglist,
                msg = "a"
            };
            return Json(data,JsonRequestBehavior.AllowGet);
            
        }
        #endregion

    }
}