using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.BusinessLogic.Infrostructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.Interfaces
{
     public interface IUserAPI
     {
          ResultMsg Login(UserDTO userDTO);
          ResultMsg Register(UserDTO userDTO);
          ResultMsg BuyTicket(UserDTO userDTO, IEnumerable<int> ticketIds);
          UserDTO GetUser(string mail);
     }
}
