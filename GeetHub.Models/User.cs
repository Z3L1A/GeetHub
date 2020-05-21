using System;

namespace GeetHub.Domain
{
    public sealed class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string login) : this()
        {
            Login = login;
        }
        
        public Guid Id { get; }

        public string Login { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
