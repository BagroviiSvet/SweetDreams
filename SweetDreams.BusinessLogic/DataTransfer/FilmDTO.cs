using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.DataTransfer
{
     public class FilmDTO
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public string TrailerUrl { get; set; }
          public TimeSpan Duration { get; set; }
          public IEnumerable<ShowDTO> Shows { get; set; }
     }
}
