using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Plumbing
{
    public class CreateMinidumpOnExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            var dumpFileName = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dmp");
            MiniDumper.Write(dumpFileName);

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewBag = { dumpFileName = dumpFileName }
            };
        }
    }
}