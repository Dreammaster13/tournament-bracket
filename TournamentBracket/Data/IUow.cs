namespace TournamentBracket.Data
{
    public interface IUow
    {
        IRepository<Models.Round> Rounds { get; }
        IRepository<Models.Match> Matches { get; }
        IRepository<Models.Entrant> Entrants { get; }
        IRepository<Models.DigitalAsset> DigitalAssets { get; }
        IRepository<Models.Division> Divisions { get; }
        void SaveChanges();
    }
}
