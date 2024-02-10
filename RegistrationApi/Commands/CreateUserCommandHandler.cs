using Ahu.Domain.User;
using MediatR;

namespace Ahu.Api.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserCreatedDto>
    {
        private readonly ILogger<CreateUserCommandHandler> _logger;
        private readonly IUserRepository _userRepo;

        public CreateUserCommandHandler(ILogger<CreateUserCommandHandler> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public Task<UserCreatedDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if(request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return HandleInternalAsync(request);
        }

        private async Task<UserCreatedDto> HandleInternalAsync(CreateUserCommand request)
        {
            //TODO: Hash password

            _logger.LogInformation("Entering Create User Command Handler");
            _logger.LogInformation("Attempting to create user...");

            User user = new User(request.FirstName, request.LastName, request.Email, request.Phone, request.Password, request.UserType);
            await _userRepo.AddAsync(user);
            await _userRepo.CompleteAsync();

            _logger.LogInformation("User successfully created");

            return new UserCreatedDto
            {
                UserId = user.Id
            };

        }
    }
}
