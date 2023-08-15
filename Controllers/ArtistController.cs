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
        [ProducesResponseType(typeof(BaseResponse<IEnumerable<ArtistsDto>>), 200)]
        public async Task<IActionResult> Artist([FromQuery] BaseSearchViewModel model)
        {

            try
            {
                return ReturnResponse(await _artistService.GettAll(model));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }
    }
}
