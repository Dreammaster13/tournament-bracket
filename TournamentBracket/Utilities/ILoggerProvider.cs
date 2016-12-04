namespace TournamentBracket.Utilities
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
