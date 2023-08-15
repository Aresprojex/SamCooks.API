using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class ArtistEraMapping : IEntityTypeConfiguration<ArtistEra>
    {
        public void Configure(EntityTypeBuilder<ArtistEra> builder)
        {
            var artistsEra = new List<ArtistEra>();

            artistsEra.Add(new ArtistEra
            {
                Id = Guid.Parse("5766d40c-03dc-4cbc-9311-68e02fd2c714"),
                EraId = Guid.Parse("2fd8696a-414b-41e7-a661-b0dbddc309fa"), // 1995
                ArtistId = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d") // 21 Savage
            });

            artistsEra.Add(new ArtistEra
            {
                Id = Guid.Parse("24cddc59-1ed9-4e36-b90a-874f344a9cd7"),
                EraId = Guid.Parse("24889416-93f3-44ee-a240-d3d03c5acdd2"), // 1999
                ArtistId = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d") // 21 Savage
            });

            builder.HasData(artistsEra);
        }
    }
}
