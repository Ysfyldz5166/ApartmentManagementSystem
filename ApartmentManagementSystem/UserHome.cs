using System;
using System.Linq;
using System.Windows.Forms;
using ApartmentManagementSystem.BusinessLogic;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentManagementSystem
{
    public partial class UserHome : Form
    {
        private readonly FamilyMemberService _familyMemberService;
        private readonly NotificationService _notificationService;
        private readonly ApartmentManagementContext _context;
        private readonly IServiceProvider _serviceProvider;
        private readonly int _userId;

        public UserHome(FamilyMemberService familyMemberService, NotificationService notificationService, ApartmentManagementContext context, IServiceProvider serviceProvider, int userId)
        {
            _familyMemberService = familyMemberService;
            _notificationService = notificationService;
            _context = context;
            _serviceProvider = serviceProvider;
            _userId = userId;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadUserData();
            CheckForNewNotifications();
        }

        private void LoadUserData()
        {
            User user = _context.Users.SingleOrDefault(u => u.UserID == _userId);
            if (user != null)
            {
                labelWelcome.Text = $"Hoşgeldiniz, {user.Username}";
            }
            else
            {
                labelWelcome.Text = "Kullanıcı bulunamadı.";
            }
        }

        private async void CheckForNewNotifications()
        {
            var notifications = await _notificationService.GetUserNotificationsAsync(_userId);
            if (notifications != null && notifications.Any())
            {
                var latestNotification = notifications.OrderByDescending(n => n.Date).First();
                if (MessageBox.Show($"Yeni duyuru: {latestNotification.Title}\nDetayları görüntülemek ister misiniz?", "Yeni Duyuru", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var notificationDetailForm = new NotificationDetailForm(latestNotification, _notificationService);
                    notificationDetailForm.ShowDialog();
                }
            }
        }

        private void buttonViewNotifications_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewAnnouncements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Duyuruları görüntüle");
        }

        private void buttonViewPersonalInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kişisel bilgileri görüntüle");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<Form1>();
            loginForm.Show();
        }

        private void buttonAddFamilyMember_Click(object sender, EventArgs e)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserID == _userId);
            if (user != null)
            {
                var addFamilyMemberForm = new AddFamilyMember(_familyMemberService, user.ApartmentId);
                addFamilyMemberForm.ShowDialog();
            }
        }
    }
}
