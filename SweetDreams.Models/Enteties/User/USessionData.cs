using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.Models.Enteties.User
{
     public class USessionData
     {
          public string UserName { get; set; }
          public string UserPassword { get; set; }

          public DateTime SessionDate { get; set; }
     }
}
