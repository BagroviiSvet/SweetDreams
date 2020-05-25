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
     public class FilmRepository: IRepository<Film>
     {
          readonly DataContext database;

          public FilmRepository(DataContext database)
          {
               this.database = database;
          }

          public void Create(Film item)
          {
               database.Films.Add(item);
          }

          public void Delete(int id)
          {
               database.Films.Remove(Get(id));
          }

          public IEnumerable<Film> Find(Func<Film, bool> predicate)
          {
               return database.Films.Where(predicate);
          }

          public Film Get(int id)
          {
               return database.Films.Find(id);
          }

          public IEnumerable<Film> GetAll()
          {
               return database.Films.ToList();
          }

          public void Update(Film item)
          {
               database.Entry(item).State = System.Data.Entity.EntityState.Modified;
          }
     }
}

     

