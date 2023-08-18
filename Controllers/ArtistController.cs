using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamCooks.API.DTO;
using SamCooks.API.Helpers;
using SamCooks.API.Services;
using SamCooks.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : BaseController
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(BaseResponse<IEnumerable<ArtistsDto>>), 200)]
        public async Task<IActionResult> ArtistAll([FromQuery] BaseSearchViewModel model)
        {

            try
            {
                return ReturnResponse(await _artistService.GetAll(model));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [HttpGet("{artistId}")]
        [ProducesResponseType(typeof(BaseResponse<ArtistsDto>), 200)]
        [ProducesResponseType(typeof(BaseResponse<ArtistsDto>), 404)]
        public async Task<IActionResult> Artist(Guid artistId)
        {

            try
            {
                return ReturnResponse(await _artistService.Get(artistId));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(BaseResponse<bool>), 200)]
        public async Task<IActionResult> Create([FromBody] CreateArtistDto model)
        {
            try
            {
                return ReturnResponse(await _artistService.Create(model));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }
    }
}
