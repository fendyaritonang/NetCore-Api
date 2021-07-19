using Microsoft.AspNetCore.Mvc;
using System;

namespace LandonApi.Apis.V1.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Rooms2Controller : ControllerBase
    {
        [HttpGet(Name = nameof(GetRooms))]
        [ProducesResponseType(200)]
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}