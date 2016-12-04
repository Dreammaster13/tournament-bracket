namespace TournamentBracket.Dtos
{
    public class EntrantAddOrUpdateResponseDto: EntrantDto
    {
        public EntrantAddOrUpdateResponseDto(TournamentBracket.Models.Entrant entity)
            :base(entity)
        {

        }
    }
}
