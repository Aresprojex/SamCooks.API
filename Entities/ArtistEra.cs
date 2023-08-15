using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Entities
{
    public class ArtistEra : BaseEntity
    {
        public Artist Artist { get; set; }
        public Guid ArtistId { get; set; }

        public Era Era { get; set; }
        public Guid EraId { get; set; }
    }
}
