using SamCooks.API.DTO;
using SamCooks.API.Helpers;
using SamCooks.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Services
{
    public interface IArtistService
    {
        Task<BaseResponse<IEnumerable<ArtistsDto>>> GettAll(BaseSearchViewModel search);
    }
}
