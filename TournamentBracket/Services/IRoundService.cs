using TournamentBracket.Dtos;
using System.Collections.Generic;

namespace TournamentBracket.Services
{
    public interface IRoundService
    {
        RoundAddOrUpdateResponseDto AddOrUpdate(RoundAddOrUpdateRequestDto request);
        ICollection<RoundDto> Get();
        RoundDto GetById(int id);
        dynamic Remove(int id);
    }
}
