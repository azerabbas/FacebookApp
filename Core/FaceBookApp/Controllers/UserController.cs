using FaceBookApplication.Application.Features.CQRS.Query.GetAllUser;
using FaceBookApplication.Application.Repositories;
using FaceBookApplication.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FaceBookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUoW _uow;

        public UserController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUserQueryRequest());
            return Ok(result);
        }

    }
}
