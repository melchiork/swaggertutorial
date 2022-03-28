using Swashbuckle.AspNetCore.Filters;

namespace SwaggerTutorial.API
{
    public class RequestDtoExample : IExamplesProvider<RequestDto>
    {
        public RequestDto GetExamples()
        {
            return new RequestDto()
            {
                Email = "mysecret@example.com",
                ReferenceId = 55567
            };
        }
    }
}