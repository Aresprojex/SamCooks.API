using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class EraMapping : IEntityTypeConfiguration<Era>
    {
        public void Configure(EntityTypeBuilder<Era> builder)
        {
            var eras = new List<Era>
            {
                new Era
                {
                    Id = Guid.Parse("2fd8696a-414b-41e7-a661-b0dbddc309fa"),
                    Date = "1995"
                },

                new Era
                {
                    Id = Guid.Parse("68005290-a3c7-4973-bd05-4ee4c3395d4d"),
                    Date = "1990"
                },

                new Era
                {
                    Id = Guid.Parse("24889416-93f3-44ee-a240-d3d03c5acdd2"),
                    Date = "1999"
                },
                new Era
                {
                    Id = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"),
                    Date = "1980"
                },
                new Era
                {
                    Id = Guid.Parse("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"),
                    Date = "2000"
                }
            };

            builder.HasData(eras);
        }
    }
}
