using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xxqLC.Controllers
{
    public class HomeController : Controller
    {

        xxqLCDBEntities db = new xxqLCDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /// <summary>
        /// 用户登录界面
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// administrator登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SysLogin()
        {
            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult RegisterAdd(string username, string pwd, string name)
        {
            UserInfo ui = new UserInfo();
            ui.Id = new Guid().ToString();
            ui.UserName = username;
            ui.UserPwd = pwd;
            ui.Name = name;
            ui.IsEffective = true;
            ui.UserCreatDate = new DateTime();
            db.UserInfo.Add(ui);
            int u = db.SaveChanges();
            if (u > 0)
            {
                Response.Write("<script>alert('注册成功!');</script>");
            }
            else
            {
                Response.Write("<script>alert('注册失败!');</script>");
            }
            return View();
        }

    }
}