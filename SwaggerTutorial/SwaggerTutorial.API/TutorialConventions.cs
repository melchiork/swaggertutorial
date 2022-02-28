using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerTutorial.API
{
    public static class TutorialConventions
    {
        [ProducesResponseType(StatusCodes.Status418ImATeapot)]
        public static void Put()
        {
        }
    }
}
