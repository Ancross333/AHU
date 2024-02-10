using Ahu.Domain.User;
using MediatR;
using System.Runtime.Serialization;

namespace Ahu.Api.Commands
{
    public class CreateUserCommand : IRequest<UserCreatedDto>
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public UserType UserType { get; set; }

        public CreateUserCommand(string firstName, string lastName, string email, string password, string phone, UserType userType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            UserType = userType;
        }
    }

    public record UserCreatedDto
    {
        public int UserId { get; set; }
    }
}
