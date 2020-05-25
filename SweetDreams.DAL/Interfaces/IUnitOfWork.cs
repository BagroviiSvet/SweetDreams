using SweetDreams.DAL.Entities;
using SweetDreams.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Interfaces
{
     public interface IUnitOfWork : IDisposable
     {
          IRepository<User> Users { get; }
          IRepository<Film> Films { get; }

          IRepository<Ticket> Tickets { get; }
          IRepository<Show> Shows { get; }

          void Save();
     }
}
