using System.Web;
using System.Web.Mvc;

namespace Lesson_02_Task_Add
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
