using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Entities
{
    public class SongKeyword : BaseEntity
    {
        public Song Song { get; set; }
        public Guid SongId { get; set; }

        public Keyword Keyword { get; set; }
        public Guid KeywordId { get; set; }
    }
}
