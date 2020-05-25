using SweetDreams.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.BusinessLogic.API
{
     public abstract class API: IDisposable
     {
          protected API(IUnitOfWork database)
          {
               this.Database = database;
          }

          protected IUnitOfWork Database { get; set; }

          public void Dispose()
          {
               Database.Dispose();
          }
     }
}
