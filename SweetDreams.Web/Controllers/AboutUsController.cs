using SweetDreams.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDreams.Web.Controllers
{
     public class AboutUsController : BaseController
     {
          // GET: AboutUs
          public ActionResult Index()
          {
               var model = new NavbarModel { User = LoggedUser };
               return View(model);
          }
     }
}