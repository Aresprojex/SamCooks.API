using Microsoft.EntityFrameworkCore;
using SamCooks.API.DbContext;
using SamCooks.API.DTO;
using SamCooks.API.Entities;
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

        public async Task<BaseResponse<ArtistDto>> Create(CreateArtistDto model)
        {
            // first check if the artist exists
            var artist = await _dbContext.Artists
                .FirstOrDefaultAsync(x => x.Name.ToLower() == model.Name.ToLower());

            // we do not allow same artist record
            if (artist != null)
            {
                return new BaseResponse<ArtistDto>("Artist already exists");
            }

            // create the artist with songs
            var artistSongs = model.Songs.Select(x => new Song
            {
                Name = x.Name,
                LinkedLyrics = x.LinkedLyrics,
                CulturallySignificant = x.CulturallySignificant,
                OverallTheme = x.OverallTheme,
                SociallyConscious = x.SociallyConscious,
                ReasonOfSelection = x.ReasonOfSelection
            }).ToList();

            // to do: add keywords for songs

            var newArtist = new Artist
            {
                Name = model.Name,
                Bio = model.Bio,
                Location = model.Location,
                Region = model.Region,
                Songs = artistSongs
            };

            await _dbContext.Artists.AddAsync(newArtist);
            var status = await _dbContext.SaveChangesAsync();


            var data = new ArtistDto
            {
                Id = newArtist.Id
            };
            return new BaseResponse<ArtistDto>(data);
        }

        public async Task<BaseResponse<ArtistDto>> Get(Guid artistId)
        {
            var artist = await _dbContext.Artists.FirstOrDefaultAsync(x => x.Id == artistId);

            if(artist == null)
            {
                return new BaseResponse<ArtistDto>("Artist not found");
            }

            var data = new ArtistDto
            {
                Id = artist.Id,
                Bio = artist.Bio,
                Name = artist.Name,
                Location = artist.Location,
                Region = artist.Region,
                TotalSongs = artist.Songs.Count(),
                Eras = artist.Eras.Select(c => new ArtistEraDto
                {
                    Era = c.Era.Date,
                    Id = c.Era.Id
                }).ToList()
            };

            return new BaseResponse<ArtistDto>(data);
        }

        // To Do: Use Automapper
        public async Task<BaseResponse<IEnumerable<ArtistsDto>>> GetAll(BaseSearchViewModel search)
        {
            var allArtists = await _dbContext.Artists
                .Select(x => new ArtistsDto { 
                    Id = x.Id,
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
