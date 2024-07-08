using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int ApartmentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Apartment Apartment { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<FamilyMember> FamilyMembers { get; set; }

    }
}
