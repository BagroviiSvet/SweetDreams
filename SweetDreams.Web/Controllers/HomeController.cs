using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDreams.Web.Controllers
{
     public class HomeController : BaseController
     {
          // GET: Home
          public ActionResult Index()
          {
               var model = new HomePageModel
               {
                    User = LoggedUser,
                    Films = CinemaAPI.GetAllFilms(),
                    LoginModel = new LoginModel(),
                    RegisterModel = new RegisterModel()
               };
               return View(model);
          }
          public ActionResult Film(int filmId)
          {
               var model = new FilmPageModel { User = LoggedUser, Film = CinemaAPI.GetFilm(filmId) };
               return View(model);
          }
          [Authorize]
          [HttpGet]
          public ActionResult Show(int showId)
          {
               var show = CinemaAPI.GetShow(showId);
               var model = new BuyTicketsModel { User = LoggedUser, Show = show };
               foreach (var ticket in show.Tickets)
               {
                    model.SelectedTickets[ticket.Row, ticket.Seat] = ticket.IsTaken;
                    model.TicketsId[ticket.Row, ticket.Seat] = ticket.Id;
               }
               return View(model);
          }
          [Authorize]
          [HttpPost]
          public ActionResult BuyTickets(ICollection<int> selectedTickets, int filmId, int showId)
          {
               var result = UserAPI.BuyTicket(LoggedUser, selectedTickets.ToList());
               if (result.Succeeded)
                    return RedirectToAction("Tickets", "Account");
               else
               {
                    ModelState.AddModelError("", result.Error);
                    return RedirectToAction("Show", new { filmId, showId });
               }
          }
     }
}