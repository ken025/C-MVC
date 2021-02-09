 using System;

namespace demomvc.Models
{
    public class PersonModel{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string EmailAddress  { get; set; }

         public string ConfirmEmail { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public bool IsAlive { get; set; } = true;
    }
}