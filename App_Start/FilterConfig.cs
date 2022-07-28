using System.Web;
using System.Web.Mvc;

namespace Eclerx.Question2MVC.JatinGupta
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
