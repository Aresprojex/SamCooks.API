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
            var artistsEra = new List<ArtistEra>
            {
                new ArtistEra
                {
                    Id = Guid.Parse("5766d40c-03dc-4cbc-9311-68e02fd2c714"),
                    EraId = Guid.Parse("2fd8696a-414b-41e7-a661-b0dbddc309fa"), // 1995
                    ArtistId = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d") // 21 Savage
                },
                new ArtistEra
                {
                    Id = Guid.Parse("24cddc59-1ed9-4e36-b90a-874f344a9cd7"),
                    EraId = Guid.Parse("24889416-93f3-44ee-a240-d3d03c5acdd2"), // 1999
                    ArtistId = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d") // 21 Savage
                },
                new ArtistEra
                {
                    Id = Guid.Parse("43d495e0-a269-46ef-aff4-2f8bd1ab3435"),
                    EraId = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), // 1980
                    ArtistId = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2") // 3rd bass
                },
                new ArtistEra
                {
                    Id = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"),
                    EraId = Guid.Parse("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"), // 2000
                    ArtistId = Guid.Parse("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9") // 50 cent
                },
                new ArtistEra
                {
                    Id = Guid.Parse("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"),
                    EraId = Guid.Parse("68005290-a3c7-4973-bd05-4ee4c3395d4d"), // 1990
                    ArtistId = Guid.Parse("e4aba257-4e44-4fec-9f36-dabbac9e6078") // Akinyele
                },
                new ArtistEra
                {
                    Id = Guid.Parse("e4aba257-4e44-4fec-9f36-dabbac9e6078"),
                    EraId = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"), // 1980
                    ArtistId = Guid.Parse("b0577578-89ca-4d61-afab-aac673fa4bfb") // Beastie Boys
                },
            };

            builder.HasData(artistsEra);
        }
    }
}
