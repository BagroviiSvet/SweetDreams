using SweetDreams.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDreams.DAL.Contexts
{
     public class DataContext : DbContext
     {
          static DataContext()
          {
               Database.SetInitializer(new AdminInitializer());
          }
          public DataContext(string nameOrConnectionString) : base(nameOrConnectionString)
          {
          }

          public DbSet<User> Users { get; set; }
          public DbSet<Ticket> Tickets { get; set; }
          public DbSet<Film> Films { get; set; }
          public DbSet<Show> Shows { get; set; }
     }

     class AdminInitializer : CreateDatabaseIfNotExists<DataContext>
     {
          protected override void Seed(DataContext context)
          {
               base.Seed(context);
               context.Users.Add(new User { Mail = "admin@admin.com", Name = "admin", Password = "admin", Role = "admin" });
               context.SaveChanges();
          }
     }
}
