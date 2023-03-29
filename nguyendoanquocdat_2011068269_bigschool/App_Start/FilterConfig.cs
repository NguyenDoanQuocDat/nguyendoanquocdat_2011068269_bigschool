using System.Web;
using System.Web.Mvc;

namespace nguyendoanquocdat_2011068269_bigschool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
