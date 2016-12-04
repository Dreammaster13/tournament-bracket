using TournamentBracket.Dtos;
using System.Collections.Generic;

namespace TournamentBracket.Services
{
    public interface IDivisionService
    {
        DivisionAddOrUpdateResponseDto AddOrUpdate(DivisionAddOrUpdateRequestDto request);
        ICollection<DivisionDto> Get();
        DivisionDto GetById(int id);
        dynamic Remove(int id);
    }
}
