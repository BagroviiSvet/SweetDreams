using SweetDreams.BusinessLogic;
using SweetDreams.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDreams.Web.Controllers
{
     public abstract class BaseController : Controller
     {
          readonly BusinessLogic.BusinessLogic bl;

          protected BaseController()
          {
               bl = new BusinessLogic.BusinessLogic();
          }
          protected IUserAPI UserAPI
          {
               get
               {
                    return bl.UserAPI;
               }
          }
          protected ICinemaAPI CinemaAPI
          {
               get
               {
                    return bl.CinemaAPI;
               }
          }
          protected IAdminAPI AdminAPI
          {
               get
               {
                    return bl.AdminAPI;
               }
          }
     }
}