using Ahu.Api.Commands;
using Ahu.Api.Requests;
using Ahu.Domain.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ahu.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;
        private readonly IUserRepository _userRepo;
        public UserController(ILogger<UserController> logger, IUserRepository userRepo, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
            _userRepo = userRepo;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddUser(CreateUserRequest request)
        {
            var cmd = new CreateUserCommand(request.FirstName, request.LastName, request.Email, request.Password, request.Phone, request.UserType);
            var data = await _mediator.Send(cmd);

            return StatusCode(StatusCodes.Status201Created, data);
        }
    }
}
