using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Apartment
    {
        public int ApartmentID { get; set; }
        public string ApartmentNumber { get; set; }
        public int Floor { get; set; }
        public string Block { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<FamilyMember> FamilyMembers { get; set; }
    }
}
