using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDreams.Web.Attributes
{
     public class AdminAttribute : AuthorizeAttribute
     {
          readonly BusinessLogic.BusinessLogic bl;


          public AdminAttribute()
          {
               bl = new BusinessLogic.BusinessLogic();
          }

          protected override bool AuthorizeCore(HttpContextBase httpContext)
          {
               return httpContext.Request.IsAuthenticated && Role(httpContext);
          }

          private bool Role(HttpContextBase httpContext)
          {
               var user = bl.UserAPI.GetUser(httpContext.User.Identity.Name);
               return user.Role == "admin";
          }
     }
}