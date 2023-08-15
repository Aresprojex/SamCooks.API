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
            var eras = new List<Era>();

            eras.Add(new Era
            {
                Id = Guid.Parse("2fd8696a-414b-41e7-a661-b0dbddc309fa"),
                Date = "1995",
                CreatedOn = DateTime.UtcNow
            });

            eras.Add(new Era
            {
                Id = Guid.Parse("24889416-93f3-44ee-a240-d3d03c5acdd2"),
                Date = "1999",
                CreatedOn = DateTime.UtcNow
            });

            builder.HasData(eras);
        }
    }
}
