using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Entities
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
        public int TotalSongs { get; set; }
        public List<Era> Eras { get; set; }
        public string Location { get; set; }
        public string Region { get; set; }
    }
}
