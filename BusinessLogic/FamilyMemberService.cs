using Entities;
using ApartmentManagementSystem.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace ApartmentManagementSystem.BusinessLogic
{
    public class FamilyMemberService
    {
        private readonly ApartmentManagementContext _context;

        public FamilyMemberService(ApartmentManagementContext context)
        {
            _context = context;
        }

        public void AddFamilyMember(FamilyMember familyMember)
        {
            _context.FamilyMembers.Add(familyMember);
            _context.SaveChanges();
        }

        public IEnumerable<FamilyMember> GetAllFamilyMembers()
        {
            return _context.FamilyMembers.ToList();
        }

        public FamilyMember GetFamilyMemberById(int id)
        {
            return _context.FamilyMembers.Find(id);
        }

        public void UpdateFamilyMember(FamilyMember familyMember)
        {
            _context.FamilyMembers.Update(familyMember);
            _context.SaveChanges();
        }

        public void DeleteFamilyMember(int id)
        {
            var familyMember = _context.FamilyMembers.Find(id);
            if (familyMember != null)
            {
                _context.FamilyMembers.Remove(familyMember);
                _context.SaveChanges();
            }
        }
    }
}
