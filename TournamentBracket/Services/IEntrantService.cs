using TournamentBracket.Dtos;
using System.Collections.Generic;

namespace TournamentBracket.Services
{
    public interface IEntrantService
    {
        EntrantAddOrUpdateResponseDto AddOrUpdate(EntrantAddOrUpdateRequestDto request);
        ICollection<EntrantDto> Get();
        EntrantDto GetById(int id);
        dynamic Remove(int id);
    }
}
