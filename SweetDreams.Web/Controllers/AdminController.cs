using SweetDreams.BusinessLogic.DataTransfer;
using SweetDreams.Web.Attributes;
using SweetDreams.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDreams.Web.Controllers
{
     public class AdminController : BaseController
     {
          [HttpGet]
          [Admin]
          public ActionResult Index()
          {
               var model = new AdminPageModel { User = LoggedUser, Films = CinemaAPI.GetAllFilms() };
               return View(model);
          }
          [HttpGet]
          [Admin]
          public ActionResult Film(int filmId)
          {
               var model = new FilmPageModel { Film = CinemaAPI.GetFilm(filmId), User = LoggedUser };
               return View(model);
          }
          [HttpGet]
          [Admin]
          public ActionResult AddFilm()
          {
               var model = new FilmModel { User = LoggedUser };
               return View(model);
          }
          [HttpPost]
          [Admin]
          public ActionResult AddFilm(FilmModel model)
          {
               if (ModelState.IsValid)
               {

                    var directory = Server.MapPath("~/img");
                    AdminAPI.AddFilm(new FilmDTO { Name = model.Name, Duration = model.Duration, TrailerUrl = model.TrailerUrl }, model.ImageUrl, directory);
                    return RedirectToAction("Index");
               }
               return View(model);
          }
          [Admin]
          public ActionResult RemoveFilm(int filmId)
          {
               AdminAPI.RemoveFilm(filmId);
               return RedirectToAction("Index");
          }
          [HttpGet]
          [Admin]
          public ActionResult AddShow(int filmId)
          {
               var model = new ShowModel { User = LoggedUser, Film = CinemaAPI.GetFilm(filmId) };
               return View(model);
          }
          [HttpPost]
          [Admin]
          public ActionResult AddShow(ShowModel model, int filmId)
          {
               if (ModelState.IsValid)
               {
                    AdminAPI.AddShow(filmId, new ShowDTO { Time = model.Time, Date = model.Date, Price=model.Price });
                    return RedirectToAction("Film", new { filmId });
               }
               model.Film = CinemaAPI.GetFilm(filmId);
               model.User = UserAPI.GetUser(User.Identity.Name);
               return View(model);
          }
          [Admin]
          public ActionResult RemoveShow(int showId, int filmId)
          {
               AdminAPI.RemoveShow(showId);
               return RedirectToAction("Film", new { filmId });
          }
     }
}