using SweetDreams.BusinessLogic.API;
using SweetDreams.BusinessLogic.Interfaces;
using SweetDreams.DAL.Interfaces;
using SweetDreams.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic
{
     public class BusinessLogic
     {
          readonly IUnitOfWork Database;

          public BusinessLogic()
          {
               Database = new UnitOfWork("FilmContext");
          }
          IUserAPI userAPI;
          public IUserAPI UserAPI
          {
               get
               {
                    if (userAPI == null)
                         userAPI = new UserAPI(Database);
                    return userAPI;
               }
          }
          ICinemaAPI cinemaAPI;
          public ICinemaAPI CinemaAPI
          {
               get
               {
                    if (cinemaAPI == null)
                         cinemaAPI = new CinemaAPI(Database);
                    return cinemaAPI;
               }
          }
          IAdminAPI adminAPI;
          public IAdminAPI AdminAPI
          {
               get
               {
                    if (adminAPI == null)
                         adminAPI = new AdminAPI(Database);
                    return adminAPI;
               }
          }
     }
}
