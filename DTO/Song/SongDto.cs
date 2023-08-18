using SamCooks.API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.DTO
{
    public class SongDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string ReasonOfSelection { get; set; }

        public SociallyConscious SociallyConscious { get; set; }

        public CulturallySignificant CulturallySignificant { get; set; }

        public string OverallTheme { get; set; }

        public SongArtistDto Artist { get; set; }

        public string LinkedLyrics { get; set; }
    }
}
