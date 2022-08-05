using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Task3
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        public User(string name, string surname, string email, string phoneNumber, string birthDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}
