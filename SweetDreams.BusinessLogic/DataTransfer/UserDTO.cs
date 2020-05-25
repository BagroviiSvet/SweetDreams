using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.DataTransfer
{
     public class UserDTO
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public string Mail { get; set; }
          public string Password { get; set; }
          public string Role { get; set; }
          public string PhoneNumber { get; set; }
          public IEnumerable<TicketDTO> Tickets { get; set; }
     }
}
