using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Entities
{
     public class User
     {
          public User()
          {
               Tickets = new List<Ticket>();
          }

          public int Id { get; set; }
          public string Name { get; set; }
          public string Mail { get; set; }
          public string Password { get; set; }
          public string Role { get; set; }
          public string PhoneNumber { get; set; }
          public virtual ICollection<Ticket> Tickets { get; set; }

     }
}
