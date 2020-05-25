using SweetDreams.DAL.Contexts;
using SweetDreams.DAL.Entities;
using SweetDreams.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Repositories
{
     class ShowRepository : IRepository<Show>
     {
          readonly DataContext database;
          public ShowRepository(DataContext database)
          {
               this.database = database;
          }

          public void Create(Show item)
          {
               database.Shows.Add(item);
          }

          public void Delete(int id)
          {
               database.Shows.Remove(Get(id));
          }

          public IEnumerable<Show> Find(Func<Show, bool> predicate)
          {
               return database.Shows.Where(predicate);
          }

          public Show Get(int id)
          {
               return database.Shows.Find(id);
          }

          public IEnumerable<Show> GetAll()
          {
               return database.Shows.ToList();
          }

          public void Update(Show item)
          {
               database.Entry(item).State = System.Data.Entity.EntityState.Modified;
          }
     }
}
