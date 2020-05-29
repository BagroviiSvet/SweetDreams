using SweetDreams.BusinessLogic;
using SweetDreams.BusinessLogic.DataTransfer;
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
          protected BaseController() => bl = new BusinessLogic.BusinessLogic();
          protected IUserAPI UserAPI => bl.UserAPI;
          protected ICinemaAPI CinemaAPI => bl.CinemaAPI;
          protected IAdminAPI AdminAPI => bl.AdminAPI;
          protected UserDTO LoggedUser => bl.UserAPI.GetUser(User.Identity.Name);
     }
}