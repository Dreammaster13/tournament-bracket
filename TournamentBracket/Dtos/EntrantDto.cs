namespace TournamentBracket.Dtos
{
    public class EntrantDto
    {
        public EntrantDto(TournamentBracket.Models.Entrant entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public EntrantDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
