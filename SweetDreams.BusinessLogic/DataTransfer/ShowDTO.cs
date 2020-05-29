using SweetDreams.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.DataTransfer
{
    public class ShowDTO : IComparable<ShowDTO>
     {
          public int Id { get; set; }
          public DateTime Date { get; set; }
          public TimeSpan Time { get; set; }
          public decimal Price { get; set; }
          public FilmDTO Film { get; set; }
          public IEnumerable<TicketDTO> Tickets { get; set; }
          public int CompareTo(ShowDTO other)
          {
               return Time.CompareTo(other.Time);
          }
     }
}
