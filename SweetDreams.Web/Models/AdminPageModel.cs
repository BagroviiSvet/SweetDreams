using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class AdminPageModel : NavbarModel
     {
          public IEnumerable<FilmDTO> Films { get; set; }
     }
}