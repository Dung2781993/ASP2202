﻿using System.Web;
using System.Web.Mvc;

namespace JWT_Demo_Net_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}