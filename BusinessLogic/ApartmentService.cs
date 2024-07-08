using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentManagementSystem.BusinessLogic
{
    public class ApartmentService
    {
        private readonly ApartmentManagementContext _context;

        public ApartmentService(ApartmentManagementContext context)
        {
            _context = context;
        }

        public async Task<List<Apartment>> GetAllApartmentsAsync()
        {
            return await _context.Apartments.ToListAsync();
        }

        public async Task<Apartment> GetApartmentByIdAsync(int id)
        {
            return await _context.Apartments.FindAsync(id);
        }

        public async Task AddApartmentAsync(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateApartmentAsync(Apartment apartment)
        {
            _context.Entry(apartment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteApartmentAsync(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            if (apartment != null)
            {
                _context.Apartments.Remove(apartment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
