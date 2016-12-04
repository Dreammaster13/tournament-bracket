using TournamentBracket.Dtos;
using System.Collections.Generic;

namespace TournamentBracket.Services
{
    public interface IMatchService
    {
        MatchAddOrUpdateResponseDto AddOrUpdate(MatchAddOrUpdateRequestDto request);
        ICollection<MatchDto> Get();
        MatchDto GetById(int id);
        dynamic Remove(int id);
    }
}
