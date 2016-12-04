namespace TournamentBracket.Data
{
    public interface IUow
    {
        IRepository<Models.Round> Rounds { get; }
        IRepository<Models.Match> Matches { get; }
        IRepository<Models.Entrant> Entrants { get; }
        void SaveChanges();
    }
}
