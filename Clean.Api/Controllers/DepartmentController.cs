using Clean.Application.Dept.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly ISender sender;
        private readonly IPublisher publisher;

        public DepartmentController(ISender sender, IPublisher publisher)
        {
            this.sender = sender;
            this.publisher = publisher;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDepartmentCommand model)
        {
            return await sender.Send(model);
        }
    }
}
