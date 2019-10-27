using System.Web;
using System.Web.Mvc;

namespace AspNetWebApp1.DotNetFramework.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
