using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.Interfaces
{
      public interface ICinemaAPI
     {
          List<FilmDTO> GetAllFilms();
          FilmDTO GetFilm(int id);
          List<ShowDTO> GetShowDTOs(int filmId);
          ShowDTO GetShow(int id);
     }
}
