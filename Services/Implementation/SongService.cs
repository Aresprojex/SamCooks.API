using Microsoft.EntityFrameworkCore;
using SamCooks.API.DbContext;
using SamCooks.API.DTO;
using SamCooks.API.Helpers;
using SamCooks.API.Services;
using SamCooks.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Services
{
    public class SongService : ISongService
    {
        private readonly ApplicationDbContext _dbContext;

        public SongService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<BaseResponse<IEnumerable<SongDto>>> GetAll(BaseSearchViewModel search)
        {
            var songs = await _dbContext.Song.Select(x => new SongDto
            {
                CulturallySignificant = x.CulturallySignificant,
                ReasonOfSelection = x.ReasonOfSelection,
                LinkedLyrics = x.LinkedLyrics,
                SociallyConscious = x.SociallyConscious,
                Name = x.Name,
                OverallTheme = x.OverallTheme,
                Id = x.Id,
                Artist = new SongArtistDto
                {
                    Name = x.Artist.Name,
                    Bio = x.Artist.Bio,
                    Id = x.ArtistId
                }
            }).ToListAsync();

            return new BaseResponse<IEnumerable<SongDto>>(songs);
        }
    }
}
