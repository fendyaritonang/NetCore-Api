using Microsoft.AspNetCore.Mvc;
using System;

namespace LandonApi.Apis.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RoomsController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRooms))]
        [ProducesResponseType(200)]
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}