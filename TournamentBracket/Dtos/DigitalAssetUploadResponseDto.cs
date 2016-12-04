using TournamentBracket.Models;
using System.Collections.Generic;

namespace TournamentBracket.Dtos
{
    public class DigitalAssetUploadResponseDto
    {
        public DigitalAssetUploadResponseDto()
        {

        }

        public DigitalAssetUploadResponseDto(ICollection<DigitalAsset> digitalAssets)
        {
            foreach (var photo in digitalAssets)
            {
                Files.Add(new DigitalAssetDto(photo));
            }
        }

        public IList<DigitalAssetDto> Files { get; set; } = new List<DigitalAssetDto>();
    }
}
