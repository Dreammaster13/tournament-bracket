namespace TournamentBracket.Dtos
{
    public class RoundDto
    {
        public RoundDto()
        {

        }

        public RoundDto(Models.Round entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
