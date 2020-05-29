using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.BusinessLogic.Interfaces;
using SweetDreams.DAL.Entities;
using SweetDreams.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.API
{
     public class CinemaAPI : API, ICinemaAPI
     {
          public CinemaAPI(IUnitOfWork database) : base(database)
          {
          }

          static FilmDTO ConvertToDTO(Film film)
          {
               if (film == null)
                    return null;
               return new FilmDTO
               {
                    Duration = film.Duration,
                    Id = film.Id,
                    Name = film.Name,
                    TrailerUrl = film.TrailerUrl,
                    Shows = film.Shows.ToList().ConvertAll(ConvertToDTO)
               };
          }
          static ShowDTO ConvertToDTO(Show show)
          {
               if (show == null)
                    return null;
               return new ShowDTO
               {
                    Id = show.Id,
                    Time = show.Time,
                    Date = show.Date,
                    Price = show.Price,
                    Film = new FilmDTO { Id = show.Film.Id, Duration = show.Film.Duration, Name = show.Film.Name, TrailerUrl = show.Film.TrailerUrl },
                    Tickets = show.Tickets.ToList().ConvertAll(ConvertToDTO)
               };
          }
          static TicketDTO ConvertToDTO(Ticket ticket)
          {
               if (ticket == null)
                    return null;
               return new TicketDTO
               {
                    Id = ticket.Id,
                    Row = ticket.Row,
                    Seat = ticket.Seat,
                    Show = new ShowDTO { Id = ticket.Show.Id, Date = ticket.Show.Date, Price = ticket.Show.Price, Time = ticket.Show.Time },
                    IsTaken = ticket.User != null
               };
          }
          public List<FilmDTO> GetAllFilms()
          {
               return Database.Films.GetAll().ToList().ConvertAll(ConvertToDTO);
          }

          public FilmDTO GetFilm(int id)
          {
               return ConvertToDTO(Database.Films.Get(id));
          }

          public ShowDTO GetShow(int id)
          {
               return ConvertToDTO(Database.Shows.Get(id));
          }

          public List<ShowDTO> GetShowDTOs(int filmId)
          {
               return Database.Films.Get(filmId).Shows.ToList().ConvertAll(ConvertToDTO);
          }
     }
}
