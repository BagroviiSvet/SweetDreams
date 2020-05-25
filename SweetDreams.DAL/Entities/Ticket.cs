using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Entities
{
     public class Ticket
     {
          public int Id { get; set; }
          public int Row { get; set; }
          public int Seat { get; set; }
          public decimal Price { get; set; }
          public virtual Show Show { get; set; }
          public virtual User User { get; set; }
     }
}
