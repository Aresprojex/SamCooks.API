using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.DTO
{
    public class SongArtistDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
