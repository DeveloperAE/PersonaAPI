using Microsoft.EntityFrameworkCore;
using Productos.Server.Models;

namespace Productos.Server.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
       
        {
            


        }


        public DbSet<Person> Persons { get; set; }

    }
}
