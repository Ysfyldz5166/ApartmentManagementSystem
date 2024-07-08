using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentManagementSystem.BusinessLogic
{
    public class NotificationService
    {
        private readonly ApartmentManagementContext _context;

        public NotificationService(ApartmentManagementContext context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetAllNotificationsAsync()
        {
            return await _context.Notifications.ToListAsync();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _context.Notifications.FindAsync(id);
        }

        public async Task AddNotificationAsync(Notification notification)
        {
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNotificationAsync(Notification notification)
        {
            _context.Entry(notification).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNotificationAsync(int id)
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Notification>> GetUserNotificationsAsync(int userId)
        {
            return await _context.Notifications.Where(n => n.UserID == userId).ToListAsync();
        }
    }
}
