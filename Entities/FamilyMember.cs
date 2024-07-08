using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FamilyMember
    {
        public int FamilyMemberID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int ApartmentID { get; set; } 
        public string Role { get; set; }

        public Apartment Apartment { get; set; }


    }
}
