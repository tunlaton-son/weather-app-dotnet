﻿using System.Web;
using System.Web.Mvc;

namespace weather_app_dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
