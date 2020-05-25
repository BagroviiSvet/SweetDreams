using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Entities
{
    public class Film
     {
          public Film()
          {
               Shows = new List<Show>();
          }
          public int Id { get; set; }
          public string Name { get; set; }
          public string TrailerUrl { get; set; }
          public TimeSpan Duration { get; set; }
          public virtual ICollection<Show> Shows { get; set; }
     }
}
