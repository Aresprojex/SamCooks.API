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
    public class SongController : BaseController
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(BaseResponse<IEnumerable<SongDto>>), 200)]
        public async Task<IActionResult> ArtistAll([FromQuery] BaseSearchViewModel model)
        {

            try
            {
                return ReturnResponse(await _songService.GetAll(model));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }
    }
}
