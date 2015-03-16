using System.Web;
using System.Web.Mvc;

namespace HBATools.Congresso.View
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}