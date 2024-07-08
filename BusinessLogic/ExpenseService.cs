using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentManagementSystem.BusinessLogic
{
    public class ExpenseService
    {
        private readonly ApartmentManagementContext _context;

        public ExpenseService(ApartmentManagementContext context)
        {
            _context = context;
        }

        public async Task<List<Expense>> GetAllExpensesAsync()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task<Expense> GetExpenseByIdAsync(int id)
        {
            return await _context.Expenses.FindAsync(id);
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateExpenseAsync(Expense expense)
        {
            _context.Entry(expense).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteExpenseAsync(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                await _context.SaveChangesAsync();
            }
        }
    }
}
