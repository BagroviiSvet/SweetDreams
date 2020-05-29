using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SweetDreams.Web.Controllers
{
     public class AccountController : BaseController
     {
          [HttpPost]
          public ActionResult Login(LoginModel model)
          {
               if (ModelState.IsValid && !User.Identity.IsAuthenticated)
               {
                    var userDTO = new UserDTO { Mail = model.Mail, Password = model.Password };
                    var result = UserAPI.Login(userDTO);
                    if (result.Succeeded)
                    {
                         FormsAuthentication.SetAuthCookie(model.Mail, true);
                         return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", result.Error);
               }
               return RedirectToAction("Index", "Home");
          }
          [HttpPost]
          public ActionResult Register(RegisterModel model)
          {
               if (ModelState.IsValid && !User.Identity.IsAuthenticated)
               {
                    var userDTO = new UserDTO
                    {
                         Name = model.Name,
                         Mail = model.Mail,
                         Password = model.Password,
                         PhoneNumber = model.PhoneNumber,
                         Role = "user"
                    };
                    var result = UserAPI.Register(userDTO);
                    if (result.Succeeded)
                    {
                         FormsAuthentication.SetAuthCookie(model.Mail, true);
                         return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(result.Reason, result.Error);
               }
               return RedirectToAction("Index", "Home");
          }
          [Authorize]
          public ActionResult Logout()
          {
               FormsAuthentication.SignOut();
               return RedirectToAction("Index", "Home");
          }
          [Authorize]
          public ActionResult Tickets()
          {
               var model = new NavbarModel { User = LoggedUser };
               return View(model);
          }
     }
}