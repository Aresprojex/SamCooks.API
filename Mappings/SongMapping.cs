using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class SongMapping : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            var songs = new List<Song>();

            songs.Add(new Song
            {
                Name = "A Lot",
                ArtistId = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"), // 21 Savage
                SociallyConscious = Enum.SociallyConscious.Yes,
                CulturallySignificant = Enum.CulturallySignificant.Yes,
                ReasonOfSelection = "This song addresses various social issues and personal experiences, including the effects of violence, racism, and the struggle for success.",
                Keywords = new List<Keyword>()
                {
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#Violence",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#Success",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#Loyalty",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#LifeOverWealthOrDeath",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#Struggles",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#Betrayal",
                    },
                    new Keyword
                    {
                        Id = Guid.NewGuid(),
                        Word = "#GunViolence",
                    }
                },
                OverallTheme = "Reflection",
                LinkedLyrics = "https://genius.com/21-savage-a-lot-lyrics"
            });

            builder.HasData(songs);
        }
    }
}
