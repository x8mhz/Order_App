using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class User
    {
        protected User() {   }
        public User(string username, string email, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            Password = password;
            Active = false;
        }

        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }

        //Relationship
        [NotMapped]
        public virtual Customer Customer { get; set; }

        public bool Login(string email, string password)
        {
            if (email != Email) return false;
            if (password != Password) return false;

            return true;
        }

    }
}
