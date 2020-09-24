using System.Web;
using System.Web.Mvc;

namespace Assignment1_n01357205
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
