using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class KeywordMappings : IEntityTypeConfiguration<Keyword>
    {
        public void Configure(EntityTypeBuilder<Keyword> builder)
        {
            var keywords = new List<Keyword>()
            {
                new Keyword
                {
                    Id = Guid.Parse("c1326157-0193-4fff-aa13-6c024b6db075"),
                    Word = "#Violence"
                },
                new Keyword
                {
                    Id = Guid.Parse("3a2d81f8-e711-4b65-bb25-e858c9718337"),
                    Word = "#Success"
                },
                new Keyword
                {
                    Id = Guid.Parse("038075d4-0f58-40f3-b94c-8e62bfafdcac"),
                    Word = "#Loyalty"
                },
                new Keyword
                {
                    Id = Guid.Parse("87631796-cb7e-4f12-9672-40de4f95666c"),
                    Word = "#LifeOverWealthOrDeath"
                },
                new Keyword
                {
                    Id = Guid.Parse("a814b9c4-1f18-42e7-8305-233ba7fa7e4c"),
                    Word = "#Struggles"
                },
                new Keyword
                {
                    Id = Guid.Parse("b69ba75f-7a49-4f3e-b0f0-7a3d9fb550c9"),
                    Word = "#Betrayal"
                },
                new Keyword
                {
                    Id = Guid.Parse("31f002c8-0686-4283-9cd0-b56ba095930a"),
                    Word = "#GunViolence"
                }
            };

            builder.HasData(keywords);
        }
    }
}
