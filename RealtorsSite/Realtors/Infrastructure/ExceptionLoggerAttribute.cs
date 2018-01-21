using System;
using System.Web.Mvc;
using Common.Logging;

namespace Realtors.Infrastructure
{
    public class ExceptionLoggerAttribute : System.Web.Mvc.HandleErrorAttribute
    {
        private readonly ILog _log = LogManager.GetLogger<ExceptionLoggerAttribute>();

        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
                throw new ArgumentNullException(nameof(filterContext));

            if (_log.IsErrorEnabled)
            {
                _log.Error($"controller: {filterContext.RouteData.Values["controller"]} | action: {filterContext.RouteData.Values["action"]}", filterContext.Exception);
            }

            base.OnException(filterContext);
        }
    }
}