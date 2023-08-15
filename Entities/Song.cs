using SamCooks.API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Entities
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }

       // [JsonProperty("Reason of Selection")]
        public string ReasonOfSelection { get; set; }

        public SociallyConscious SociallyConscious { get; set; }

        public CulturallySignificant CulturallySignificant { get; set; }

        public string OverallTheme { get; set; }

        public Artist Artist { get; set; }
        public Guid ArtistId { get; set; }

        public string LinkedLyrics { get; set; }

        public List<SongKeyword> Keywords { get; set; }
    }
}
