using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.BusinessLogic.Interfaces;
using SweetDreams.DAL.Entities;
using SweetDreams.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.API
{
     public class AdminAPI : API, IAdminAPI
     {
          public AdminAPI(IUnitOfWork database) : base(database)
          {
          }

          public void AddFilm(FilmDTO filmDTO, string imageUrl, string directory)
          {
               var film = new Film { Name = filmDTO.Name, Duration = filmDTO.Duration, TrailerUrl = filmDTO.TrailerUrl };
               Database.Films.Create(film);
               Database.Save();
               using (WebClient client = new WebClient())
               {
                    client.DownloadFile(new Uri(imageUrl), directory + "/" + film.Id + ".jpg");
               }
          }

          public void AddShow(int filmId, ShowDTO showDTO)
          {
               var film = Database.Films.Get(filmId);
               film.Shows.Add(new Show { Time = showDTO.Time, Date = showDTO.Date });
               Database.Save();
          }

          public void RemoveFilm(int filmId)
          {
               Database.Films.Delete(filmId);
               Database.Save();
          }

          public void RemoveShow(int showId)
          {
               Database.Shows.Delete(showId);
               Database.Save();
          }
     }
}
