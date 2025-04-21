using AgendaContactosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AgendaContactosAPI.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
    }

}
