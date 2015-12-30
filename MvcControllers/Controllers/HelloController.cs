using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcControllers.in

namespace MvcControllers.Controllers
{
    public class HelloController : IController
    {
        #region IController Members

        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("Hello, World!");
        }

        #endregion



    }
}