using Microsoft.AspNetCore.Mvc;

namespace LandonApi.Apis.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class RootController : ControllerBase
    {
        /// <summary>
        /// Root API
        /// </summary>
        /// <remarks>
        /// This is remarks information. You can put any information here:
        /// </remarks>
        /// <response code="200">Successful return</response>
        /// <response code="400">Bad request</response>
        [HttpGet(Name = nameof(GetRoot))]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                rooms = new
                {
                    href = Url.Link(nameof(RoomsController.GetRooms), null)
                }
            };

            return Ok(response);
        }
    }
}