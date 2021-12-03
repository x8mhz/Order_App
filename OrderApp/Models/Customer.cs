using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class Customer
    {
        protected Customer() {   }
        public Customer(string firstName, string lastName, string document, string phone)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Phone = phone;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }

        //Relationship
        [NotMapped]
        public virtual User User { get; set; }
    }
}
