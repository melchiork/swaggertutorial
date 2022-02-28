using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerTutorial.API
{
    /// <summary>
    /// Request for Other resource, in detail!
    /// </summary>
    public class RequestDto
    {
        [Required]
        [Range(1,5000)]
        public int ReferenceId { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
