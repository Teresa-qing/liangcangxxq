using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xxqLC.Controllers
{
    [Authorize]
    public class SystemManageController : Controller
    {

        xxqLCDBEntities db = new xxqLCDBEntities();

        // GET: SystemManage
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <returns></returns>
        public ActionResult UserInfo()
        {
            string sql = "select * from UserInfo";
            List<UserInfo> listui = db.Database.SqlQuery<UserInfo>(sql).ToList() as List<UserInfo>;
            Session["listui"] = listui;
            return View();
        }

        /// <summary>
        /// 登录日志
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginLog()
        {
            string sql = "select * from LoginLog";
            List<LoginLog> listll = db.Database.SqlQuery<LoginLog>(sql).ToList() as List<LoginLog>;
            return View();
        }

        /// <summary>
        /// 操作日志
        /// </summary>
        /// <returns></returns>
        public ActionResult OperateLog()
        {
            string sql = "select * from OperateLog";
            List<OperateLog> listol = db.Database.SqlQuery<OperateLog>(sql).ToList() as List<OperateLog>;
            return View();
        }

        /// <summary>
        /// 数据类别
        /// </summary>
        /// <returns></returns>
        public ActionResult DataType()
        {
            string sql = "select * from ContentType";
            List<ContentType> listct = db.Database.SqlQuery<ContentType>(sql).ToList() as List<ContentType>;
            return View();
        }

        /// <summary>
        /// 数据信息
        /// </summary>
        /// <returns></returns>
        public ActionResult DataInfo()
        {
            string sql = "select * from ContentInfo";
            List<ContentInfo> listci = db.Database.SqlQuery<ContentInfo>(sql).ToList() as List<ContentInfo>;
            return View();
        }
    }
}