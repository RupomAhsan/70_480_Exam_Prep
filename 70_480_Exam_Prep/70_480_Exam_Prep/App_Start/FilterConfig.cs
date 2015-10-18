using System.Web;
using System.Web.Mvc;

namespace _70_480_Exam_Prep
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
