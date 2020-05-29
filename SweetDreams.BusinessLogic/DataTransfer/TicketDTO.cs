using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.DataTransfer
{
    public class TicketDTO
     {
          public int Id { get; set; }
          public int Row { get; set; }
          public int Seat { get; set; }
          public ShowDTO Show { get; set; }
          public bool IsTaken { get; set; }
     }
}
