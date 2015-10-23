using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.Azure;

namespace aspmvc4azure.web
{
    public class UserProfilePictureActionFilter : ActionFilterAttribute
    {

        // Unitrusive way of creating global viewbag values
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var appName = CloudConfigurationManager.GetSetting("ApplicationName");
            if (appName.IsNullOrWhiteSpace())
                appName = "Define name in cloud config";
            filterContext.Controller.ViewBag.ApplicationName = appName;
        }

    }
}