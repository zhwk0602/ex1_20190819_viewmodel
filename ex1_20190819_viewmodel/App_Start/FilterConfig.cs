using System.Web;
using System.Web.Mvc;

namespace ex1_20190819_viewmodel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
