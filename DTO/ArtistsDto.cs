using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.DTO
{
    public class ArtistsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public int TotalSongs { get; set; }
        public List<ArtistEraDto> Eras { get; set; }
        public string Location { get; set; }
        public string Region { get; set; }
    }
}
