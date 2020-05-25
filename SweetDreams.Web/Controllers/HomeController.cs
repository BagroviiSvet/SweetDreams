using SweetDreams.Web.Models;
using System;
using System.Collections.Generic;
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
                    User = UserAPI.GetUser(User.Identity.Name),
                    Films = CinemaAPI.GetAllFilms(),
                    LoginModel = new LoginModel(),
                    RegisterModel = new RegisterModel()
               };
               return View(model);
          }
          public ActionResult Film(int filmId)
          {
               var model = new FilmPageModel { User = UserAPI.GetUser(User.Identity.Name), Film = CinemaAPI.GetFilm(filmId) };
               return View(model);
          }
     }
}