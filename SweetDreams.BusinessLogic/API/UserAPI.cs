using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.BusinessLogic.Infrostructure;
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
     public class UserAPI : API, IUserAPI
     {
          public UserAPI(IUnitOfWork database) : base(database)
          {
          }

          public ResultMsg BuyTicket(UserDTO userDTO, IEnumerable<int> ticketIds)
          {
               User user = Database.Users.Find(u => u.Mail == userDTO.Mail).FirstOrDefault();
               var tickets = new List<Ticket>();
               foreach (var ticketId in ticketIds)
               {
                    var ticket = Database.Tickets.Get(ticketId);
                    if (ticket.User != null)
                         return new ResultMsg { Succeeded = false, Error = "Ticket is already bought" };
                    tickets.Add(ticket);
               }
               foreach (var ticket in tickets)
               {
                    user.Tickets.Add(ticket);
                    Database.Save();
               }
               return new ResultMsg { Succeeded = true };
          }

          public ResultMsg Login(UserDTO userDTO)
          {

               User user = Database.Users.Find(u => u.Mail == userDTO.Mail && u.Password == userDTO.Password).FirstOrDefault();
               if (user == null)
               {
                    return new ResultMsg { Succeeded = false, Error = "Password or Mail are invalid", Reason = "" };
               }
               else
                    return new ResultMsg { Succeeded = true };
          }

          public ResultMsg Register(UserDTO userDTO)
          {
               User user = Database.Users.Find(u => u.Mail == userDTO.Mail).FirstOrDefault();
               if (user != null)
               {
                    return new ResultMsg { Succeeded = false, Error = "Mail is already used", Reason = "Mail" };

               }
               user = Database.Users.Find(u => u.Name == userDTO.Name).FirstOrDefault();
               if (user != null)
                    return new ResultMsg { Succeeded = false, Error = "Name is already used", Reason = "Name" };
               else
               {
                    Database.Users.Create(ConvertFromDTO(userDTO));
                    Database.Save();
                    return new ResultMsg { Succeeded = true };
               }
          }

          static User ConvertFromDTO(UserDTO userDTO)
          {
               if (userDTO == null)
                    return null;
               return new User
               {
                    Mail = userDTO.Mail,
                    Name = userDTO.Name,
                    Password = userDTO.Password,
                    PhoneNumber = userDTO.PhoneNumber,
                    Role = userDTO.Role
               };
          }

          static UserDTO ConvertToDTO(User user)
          {
               if (user == null)
                    return null;
               return new UserDTO
               {
                    Id = user.Id,
                    Mail = user.Mail,
                    PhoneNumber = user.PhoneNumber,
                    Role = user.Role,
                    Name = user.Name,
                    Tickets = user.Tickets.ToList().ConvertAll(ConvertToDTO)
               };
          }

          internal static TicketDTO ConvertToDTO(Ticket ticket)
          {
               if (ticket == null)
                    return null;
               return new TicketDTO
               {
                    Id = ticket.Id,
                    Row = ticket.Row,
                    Seat = ticket.Seat,
                    Show = new ShowDTO
                    {
                         Id = ticket.Show.Id,
                         Date = ticket.Show.Date,
                         Price = ticket.Show.Price,
                         Time = ticket.Show.Time,
                         Film = new FilmDTO
                         {
                              Id = ticket.Show.Film.Id,
                              Duration = ticket.Show.Film.Duration,
                              Name = ticket.Show.Film.Name,
                              TrailerUrl = ticket.Show.Film.TrailerUrl
                         }
                    },
                    IsTaken = ticket.User != null
               };
          }

          public UserDTO GetUser(string mail)
          {
               var user = Database.Users.Find(u => u.Mail == mail).FirstOrDefault();
               return ConvertToDTO(user);
          }
     }
}
