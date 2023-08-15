using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class SongKeywordMapping : IEntityTypeConfiguration<SongKeyword>
    {
        public void Configure(EntityTypeBuilder<SongKeyword> builder)
        {
            var keywords = new List<SongKeyword>()
            {
                new SongKeyword
                {
                    Id = Guid.Parse("c1326157-0193-4fff-aa13-6c024b6db075"),
                    SongId = Guid.Parse("24cddc59-1ed9-4e36-b90a-874f344a9cd7"),
                    KeywordId = Guid.Parse("c1326157-0193-4fff-aa13-6c024b6db075")
                },
                new SongKeyword
                {
                    Id = Guid.Parse("cdec1b46-f382-4b34-a376-c4e1952f6340"),
                    SongId = Guid.Parse("24cddc59-1ed9-4e36-b90a-874f344a9cd7"),
                    KeywordId = Guid.Parse("3a2d81f8-e711-4b65-bb25-e858c9718337")
                }                
            };

            builder.HasData(keywords);
        }
    }
}
