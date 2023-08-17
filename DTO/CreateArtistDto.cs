using SamCooks.API.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.DTO
{
    public class CreateArtistDto 
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Bio { get; set; }

        public List<Guid> Eras { get; set; }

        public string Location { get; set; }

        public string Region { get; set; }

        public IEnumerable<CreateArtistAndSongDto> Songs { get; set; }
    }

    public class CreateArtistAndSongDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ReasonOfSelection { get; set; }

        [Required]
        public SociallyConscious SociallyConscious { get; set; }

        [Required]
        public CulturallySignificant CulturallySignificant { get; set; }

        public string OverallTheme { get; set; }

        public string LinkedLyrics { get; set; }

        public List<Guid> Keywords { get; set; } // Todo: should be aple to upsert
    }
}
