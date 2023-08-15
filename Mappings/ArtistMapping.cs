using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class ArtistMapping : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            var artists = new List<Artist>
            {
                new Artist
                {
                    Id = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"),
                    Name = "21 Savage",
                    Bio = "21 Savage is a British rapper known for his <i>distinct trap style</i> and introspective lyrics. Born in London, he moved to Atlanta at a young age and emerged as a prominent figure in the hip-hop scene. His music often reflects on his personal experiences, addressing topics like <i>violence</i>, <i>poverty</i>, and <b><span style='color: red';>social injustice</span></b>.",
                    Region = "South",
                    Location = "Atlanta, Georgia"
                },
            };

            builder.HasData(artists);
        }
    }
}
