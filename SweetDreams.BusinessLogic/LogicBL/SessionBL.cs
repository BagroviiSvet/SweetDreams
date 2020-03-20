using SweetDreams.BusinessLogic.Core;
using SweetDreams.BusinessLogic.Interfaces;
using SweetDreams.Models.Enteties.General;
using SweetDreams.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.LogicBL
{
     class SessionBL : UserApi, ISession
     {
          public ResponseMsg GetUserSession(USessionData udata)
          {
               return UserSession(udata);
          }
     }
}
