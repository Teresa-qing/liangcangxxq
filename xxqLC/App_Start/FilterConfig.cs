using System.Web;
using System.Web.Mvc;

namespace xxqLC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());//注册全局过滤器
            filters.Add(new HandleErrorAttribute());
        }
    }
}
