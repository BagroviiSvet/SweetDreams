using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class HomePageModel : NavbarModel
     {
          public LoginModel LoginModel { get; set; }
          public RegisterModel RegisterModel { get; set; }
          public IEnumerable<FilmDTO> Films { get; set; }
     }
}