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
     public class UserRepository : IRepository<User>
     {
          readonly DataContext database;

          public UserRepository(DataContext database)
          {
               this.database = database;
          }

          public void Create(User item)
          {
               database.Users.Add(item);
          }

          public void Delete(int id)
          {
               database.Users.Remove(Get(id));
          }

          public IEnumerable<User> Find(Func<User, bool> predicate)
          {
              return database.Users.Where(predicate).ToList();
          }

          public User Get(int id)
          {
              return database.Users.Find(id);
          }

          public IEnumerable<User> GetAll()
          {
               return database.Users.ToList();
          }

          public void Update(User item)
          {
               database.Entry(item).State = System.Data.Entity.EntityState.Modified;
          }
     }
}
