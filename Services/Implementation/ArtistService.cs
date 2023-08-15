using Microsoft.EntityFrameworkCore;
using SamCooks.API.DbContext;
using SamCooks.API.DTO;
using SamCooks.API.Helpers;
using SamCooks.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Services
{
    public class ArtistService : IArtistService
    {
        private readonly ApplicationDbContext _dbContext;

        public ArtistService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BaseResponse<IEnumerable<ArtistsDto>>> GettAll(BaseSearchViewModel search)
        {
            var allArtists = await _dbContext.Artists
                .Select(x => new ArtistsDto { 
                    Bio = x.Bio,
                    Name = x.Name,
                    Location = x.Location,
                    Region = x.Region,
                    TotalSongs = x.Songs.Count(),
                    Eras = x.Eras.Select(c => new ArtistEraDto
                    {
                        Era = c.Era.Date,
                        Id = c.Era.Id
                    }).ToList()
                }).ToListAsync();

            return new BaseResponse<IEnumerable<ArtistsDto>>(allArtists);
        }
    }
}
