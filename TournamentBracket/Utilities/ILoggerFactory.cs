using System.Collections.Generic;

namespace TournamentBracket.Utilities
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
