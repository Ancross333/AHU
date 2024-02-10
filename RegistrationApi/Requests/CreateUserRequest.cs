using Ahu.Domain.User;

namespace Ahu.Api.Requests
{
    public class CreateUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public string Phone { get; set; }

        public CreateUserRequest() { }
    }
}
