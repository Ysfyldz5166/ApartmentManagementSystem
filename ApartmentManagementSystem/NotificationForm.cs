using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentManagementSystem.BusinessLogic;
using ApartmentManagementSystem.DataAccess;
using Entities;

namespace ApartmentManagementSystem
{
    public partial class NotificationForm : Form
    {
        private readonly NotificationService _notificationService;
        private readonly ApartmentManagementContext _context;

        public NotificationForm(NotificationService notificationService, ApartmentManagementContext context)
        {
            _notificationService = notificationService;
            _context = context;
            InitializeComponent();
            LoadUsers();
            ResizeForm();
        }

        private void LoadUsers()
        {
            var users = _context.Users.ToList();
            listBoxUsers.DataSource = users;
            listBoxUsers.DisplayMember = "Username";
            listBoxUsers.ValueMember = "UserID";
        }

        private async void buttonSendNotification_Click(object sender, EventArgs e)
        {
            var notification = new Notification
            {
                Title = textBoxTitle.Text,
                Message = GenerateMessage(),
                Date = DateTime.Now,
                Type = comboBoxNotificationType.SelectedItem.ToString(),
                Statement = false 
            };

            if (checkBoxAllUsers.Checked)
            {
                await SendNotificationToAllUsers(notification);
            }
            else
            {
                var selectedUserIds = listBoxUsers.SelectedItems.Cast<User>().Select(u => u.UserID).ToList();
                await SendNotificationToSelectedUsers(notification, selectedUserIds);
            }

            MessageBox.Show("Bildirim başarıyla gönderildi.");
            this.Close();
        }

        private string GenerateMessage()
        {
            string type = comboBoxNotificationType.SelectedItem.ToString();
            switch (type)
            {
                case "Ödeme":
                    return $"Ödeme Bildirimi: \nSon Ödeme Tarihi: {dateTimePickerPaymentDueDate.Value.ToShortDateString()}\nFiyat: {textBoxPaymentAmount.Text} TL";
                case "Toplantı":
                    return $"Toplantı Bildirimi: \nTarih: {dateTimePickerMeetingDate.Value.ToShortDateString()}\nYer: {textBoxMeetingPlace.Text}\nKonu: {textBoxMeetingTopic.Text}";
                case "Duyuru":
                    return $"Duyuru: \nKonu: {textBoxAnnouncementTopic.Text}\nMesaj: {textBoxMessage.Text}";
                default:
                    return textBoxMessage.Text;
            }
        }

        private async Task SendNotificationToAllUsers(Notification notification)
        {
            var users = _context.Users.ToList();
            foreach (var user in users)
            {
                var userNotification = new Notification
                {
                    Title = notification.Title,
                    Message = notification.Message,
                    Date = notification.Date,
                    UserID = user.UserID,
                    Type = notification.Type,
                    Statement = notification.Statement
                };
                await _notificationService.AddNotificationAsync(userNotification);
            }
        }
        private void comboBoxNotificationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxNotificationType.SelectedItem.ToString();

            panelPayment.Visible = selectedType == "Ödeme";
            panelMeeting.Visible = selectedType == "Toplantı";
            panelAnnouncement.Visible = selectedType == "Duyuru";
        }


        private async Task SendNotificationToSelectedUsers(Notification notification, List<int> userIds)
        {
            foreach (var userId in userIds)
            {
                var userNotification = new Notification
                {
                    Title = notification.Title,
                    Message = notification.Message,
                    Date = notification.Date,
                    UserID = userId,
                    Type = notification.Type,
                    Statement = notification.Statement,
                };
                await _notificationService.AddNotificationAsync(userNotification);
            }
        }

        private void checkBoxAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            listBoxUsers.Enabled = !checkBoxAllUsers.Checked;
        }

        private void ResizeForm()
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
