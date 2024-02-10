using System.ComponentModel.DataAnnotations;

namespace Ahu.Domain.User
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public UserType UserType { get; private set; }

        public User() { }
        public User(string firstname, string lastname, string email, string phone, string password, UserType type)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Password = password;
            UserType = type;
        }
    }
}
