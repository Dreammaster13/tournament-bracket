namespace TournamentBracket.Dtos
{
    public class MatchDto
    {
        public MatchDto(TournamentBracket.Models.Match entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public MatchDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
