using Microsoft.EntityFrameworkCore;

namespace appweb001.Models
{
    public class ContextoDeDatos: DbContext
    {
        public DbSet<Contactos> contactos { get; set; }

        public ContextoDeDatos(DbContextOptions <ContextoDeDatos> options)
            : base(options)
        {
        }




    }
}
