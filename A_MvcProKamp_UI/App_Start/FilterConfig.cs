﻿using System.Web;
using System.Web.Mvc;

namespace A_MvcProKamp_UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
