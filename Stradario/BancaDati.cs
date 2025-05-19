using Microsoft.EntityFrameworkCore;
using Stradario.Strutture;

namespace Stradario
{
    /*
        dotnet tool install --global dotnet-ef
        dotnet ef
        dotnet ef migrations add Prima (...o Seconda...)
        dotnet ef database update
     */
    public class BancaDati : DbContext
    {
        public DbSet<Nodo> nodi {  get; set; }
        public DbSet<Arco> archi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mappa.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
