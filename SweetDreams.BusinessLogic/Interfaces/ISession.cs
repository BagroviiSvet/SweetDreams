using SweetDreams.Models.Enteties.General;
using SweetDreams.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.Interfaces
{
     public interface ISession
     {
          ResponseMsg GetUserSession(USessionData udata);
     }
}
