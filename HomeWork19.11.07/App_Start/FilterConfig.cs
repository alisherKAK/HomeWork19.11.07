﻿using System.Web;
using System.Web.Mvc;

namespace HomeWork19._11._07
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
