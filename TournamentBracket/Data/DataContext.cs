using System.Data.Entity;

namespace TournamentBracket.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "TournamentBracketDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Models.Round> Rounds { get; set; }
        public DbSet<Models.Match> Matches { get; set; }
        public DbSet<Models.Entrant> Entrants { get; set; }
        public DbSet<Models.DigitalAsset> DigitalAssets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}
