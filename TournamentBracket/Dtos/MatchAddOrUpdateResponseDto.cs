namespace TournamentBracket.Dtos
{
    public class MatchAddOrUpdateResponseDto: MatchDto
    {
        public MatchAddOrUpdateResponseDto(TournamentBracket.Models.Match entity)
            :base(entity)
        {

        }
    }
}
