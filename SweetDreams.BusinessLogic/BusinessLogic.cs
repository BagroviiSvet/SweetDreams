using SweetDreams.BusinessLogic.Interfaces;
using SweetDreams.BusinessLogic.LogicBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic
{
     public class BusinessLogic
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }

          public IMain GetMainBL()
          {
               return new MainBL();
          }
     }
}
