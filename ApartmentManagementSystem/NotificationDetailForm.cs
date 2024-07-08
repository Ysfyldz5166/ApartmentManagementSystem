using System;
using System.Windows.Forms;
using Entities;
using ApartmentManagementSystem.BusinessLogic;

namespace ApartmentManagementSystem
{
    public partial class NotificationDetailForm : Form
    {
        private readonly Notification _notification;
        private readonly NotificationService _notificationService;

        public NotificationDetailForm(Notification notification, NotificationService notificationService)
        {
            _notification = notification;
            _notificationService = notificationService;
            InitializeComponent();
            LoadNotificationDetails();
        }

        private void LoadNotificationDetails()
        {
            labelTitle.Text = _notification.Title;
            textBoxMessage.Text = _notification.Message;
            labelDate.Text = _notification.Date.ToString("g");

            if (_notification.Type == "Toplantı")
            {
                buttonAttend.Visible = true;
                buttonNotAttend.Visible = true;
            }
        }

        private async void buttonAttend_Click(object sender, EventArgs e)
        {
            _notification.Statement = true;
            await _notificationService.UpdateNotificationAsync(_notification);
            MessageBox.Show("Katılım durumunuz kaydedildi.");
            this.Close();
        }

        private async void buttonNotAttend_Click(object sender, EventArgs e)
        {
            _notification.Statement = false;
            await _notificationService.UpdateNotificationAsync(_notification);
            MessageBox.Show("Katılım durumunuz kaydedildi.");
            this.Close();
        }
    }
}
