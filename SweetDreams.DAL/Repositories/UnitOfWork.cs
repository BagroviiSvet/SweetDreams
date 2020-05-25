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
     public class UnitOfWork : IUnitOfWork
     {
          readonly DataContext database;
          public UnitOfWork(string Connection)
          {
               database = new DataContext(Connection);
               Users = new UserRepository(database);
               Films = new FilmRepository(database);
               Tickets = new TicketRepository(database);
               Shows = new ShowRepository(database);
          }
          public IRepository<User> Users { get; }
          public IRepository<Film> Films { get; }
          public IRepository<Ticket> Tickets { get; }
          public IRepository<Show> Shows { get; }

          public void Save()
          {
               database.SaveChanges();
          }
          #region IDisposable Support
          private bool disposedValue = false;
          protected virtual void Dispose(bool disposing)
          {
               if (!disposedValue)
               {
                    if (disposing)
                    {
                         database.Dispose();
                    }
                    disposedValue = true;
               }
          }
          public void Dispose()
          {
               Dispose(true);

          }
          #endregion
     }
}
