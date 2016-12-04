namespace TournamentBracket.Dtos
{
    public class DivisionDto
    {
        public DivisionDto(TournamentBracket.Models.Division entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public DivisionDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
