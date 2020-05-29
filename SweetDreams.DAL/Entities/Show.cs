using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Entities
{
    public class Show
     {
          public Show()
          {
               Tickets = new List<Ticket>();
          }

          public int Id { get; set; }
          public DateTime Date { get; set; }
          public TimeSpan Time { get; set; }
          public decimal Price { get; set; }
          public virtual Film Film { get; set; }
          public virtual ICollection<Ticket> Tickets { get; set; }
     }
}
