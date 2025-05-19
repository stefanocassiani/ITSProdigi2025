using Microsoft.EntityFrameworkCore;
using Stradario.Strutture;

namespace Stradario
{
    public class BancaDati : DbContext
    {
        public DbSet<Nodo> nodi {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mappa.sqlite;Version=3;New=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
