using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerTutorial.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class OtherController : ControllerBase
    {
        /// <summary>
        /// Requests Other resource for specified params
        /// </summary>
        ///<remarks>
        /// Sample request:
        ///
        ///     POST /other
        ///     {
        ///        "referenceId": 12,
        ///        "email": "person@example.com"
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Request went fine</response>
        /// <response code="404">Validation issue</response>
        /// <response code="418">A Teapot</response>
        [HttpPost]
        public IActionResult Post([FromBody] RequestDto requestDto)
        {
            return null;
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        public IActionResult Put([FromBody] RequestDto requestDto)
        {
            return null;
        }


        [HttpPut("WithTea")]
        [ApiConventionMethod(typeof(TutorialConventions), nameof(TutorialConventions.Put))]
        public IActionResult PutWithTea([FromBody] RequestDto requestDto)
        {
            return null;
        }
    }
}
