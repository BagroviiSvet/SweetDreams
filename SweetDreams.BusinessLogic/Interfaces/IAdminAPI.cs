using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.Interfaces
{
     public interface IAdminAPI
     {
          void AddFilm(FilmDTO filmDTO, string imageUrl, string directory);
          void RemoveFilm(int filmId);
          void AddShow(int filmId, ShowDTO showDTO);
          void RemoveShow(int showId);
     }
}
