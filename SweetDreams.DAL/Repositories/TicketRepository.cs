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
    public class TicketRepository: IRepository<Ticket>
     {
          readonly DataContext database;
          public TicketRepository(DataContext database)
          {
               this.database = database;
          }

          public void Create(Ticket item)
          {
               database.Tickets.Add(item);
          }

          public void Delete(int id)
          {
               database.Tickets.Remove(Get(id));
          }

          public IEnumerable<Ticket> Find(Func<Ticket, bool> predicate)
          {
               return database.Tickets.Where(predicate);
          }

          public Ticket Get(int id)
          {
               return database.Tickets.Find(id);
          }

          public IEnumerable<Ticket> GetAll()
          {
               return database.Tickets.ToList();
          }

          public void Update(Ticket item)
          {
               database.Entry(item).State = System.Data.Entity.EntityState.Modified;
          }
     }
}
