namespace ApartmentManagementSystem
{
    partial class NotificationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.checkBoxAllUsers = new System.Windows.Forms.CheckBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonSendNotification = new System.Windows.Forms.Button();
            this.comboBoxNotificationType = new System.Windows.Forms.ComboBox();
            this.labelNotificationType = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.labelPaymentDueDate = new System.Windows.Forms.Label();
            this.dateTimePickerPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.textBoxPaymentAmount = new System.Windows.Forms.TextBox();
            this.panelMeeting = new System.Windows.Forms.Panel();
            this.labelMeetingDate = new System.Windows.Forms.Label();
            this.dateTimePickerMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.labelMeetingPlace = new System.Windows.Forms.Label();
            this.textBoxMeetingPlace = new System.Windows.Forms.TextBox();
            this.labelMeetingTopic = new System.Windows.Forms.Label();
            this.textBoxMeetingTopic = new System.Windows.Forms.TextBox();
            this.panelAnnouncement = new System.Windows.Forms.Panel();
            this.labelAnnouncementTopic = new System.Windows.Forms.Label();
            this.textBoxAnnouncementTopic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTitle.Location = new System.Drawing.Point(30, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(45, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Başlık:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTitle.Location = new System.Drawing.Point(30, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(300, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMessage.Location = new System.Drawing.Point(30, 240);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(47, 17);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Mesaj:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMessage.Location = new System.Drawing.Point(30, 260);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(300, 100);
            this.textBoxMessage.TabIndex = 3;
            // 
            // checkBoxAllUsers
            // 
            this.checkBoxAllUsers.AutoSize = true;
            this.checkBoxAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAllUsers.Location = new System.Drawing.Point(30, 380);
            this.checkBoxAllUsers.Name = "checkBoxAllUsers";
            this.checkBoxAllUsers.Size = new System.Drawing.Size(128, 21);
            this.checkBoxAllUsers.TabIndex = 4;
            this.checkBoxAllUsers.Text = "Tüm Kullanıcılar";
            this.checkBoxAllUsers.UseVisualStyleBackColor = true;
            this.checkBoxAllUsers.CheckedChanged += new System.EventHandler(this.checkBoxAllUsers_CheckedChanged);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(30, 410);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxUsers.Size = new System.Drawing.Size(300, 100);
            this.listBoxUsers.TabIndex = 5;
            // 
            // buttonSendNotification
            // 
            this.buttonSendNotification.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSendNotification.ForeColor = System.Drawing.Color.White;
            this.buttonSendNotification.Location = new System.Drawing.Point(130, 520);
            this.buttonSendNotification.Name = "buttonSendNotification";
            this.buttonSendNotification.Size = new System.Drawing.Size(100, 30);
            this.buttonSendNotification.TabIndex = 6;
            this.buttonSendNotification.Text = "Gönder";
            this.buttonSendNotification.UseVisualStyleBackColor = false;
            this.buttonSendNotification.Click += new System.EventHandler(this.buttonSendNotification_Click);
            // 
            // comboBoxNotificationType
            // 
            this.comboBoxNotificationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxNotificationType.FormattingEnabled = true;
            this.comboBoxNotificationType.Items.AddRange(new object[] {
            "Ödeme",
            "Toplantı",
            "Duyuru"});
            this.comboBoxNotificationType.Location = new System.Drawing.Point(30, 110);
            this.comboBoxNotificationType.Name = "comboBoxNotificationType";
            this.comboBoxNotificationType.Size = new System.Drawing.Size(300, 24);
            this.comboBoxNotificationType.TabIndex = 7;
            this.comboBoxNotificationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotificationType_SelectedIndexChanged);
            // 
            // labelNotificationType
            // 
            this.labelNotificationType.AutoSize = true;
            this.labelNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNotificationType.Location = new System.Drawing.Point(30, 90);
            this.labelNotificationType.Name = "labelNotificationType";
            this.labelNotificationType.Size = new System.Drawing.Size(92, 17);
            this.labelNotificationType.TabIndex = 8;
            this.labelNotificationType.Text = "Bildirim Türü:";
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.labelPaymentDueDate);
            this.panelPayment.Controls.Add(this.dateTimePickerPaymentDueDate);
            this.panelPayment.Controls.Add(this.labelPaymentAmount);
            this.panelPayment.Controls.Add(this.textBoxPaymentAmount);
            this.panelPayment.Location = new System.Drawing.Point(30, 150);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(300, 80);
            this.panelPayment.TabIndex = 9;
            this.panelPayment.Visible = false;
            // 
            // labelPaymentDueDate
            // 
            this.labelPaymentDueDate.AutoSize = true;
            this.labelPaymentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentDueDate.Location = new System.Drawing.Point(0, 0);
            this.labelPaymentDueDate.Name = "labelPaymentDueDate";
            this.labelPaymentDueDate.Size = new System.Drawing.Size(122, 17);
            this.labelPaymentDueDate.TabIndex = 0;
            this.labelPaymentDueDate.Text = "Son Ödeme Tarihi:";
            // 
            // dateTimePickerPaymentDueDate
            // 
            this.dateTimePickerPaymentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerPaymentDueDate.Location = new System.Drawing.Point(0, 20);
            this.dateTimePickerPaymentDueDate.Name = "dateTimePickerPaymentDueDate";
            this.dateTimePickerPaymentDueDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerPaymentDueDate.TabIndex = 1;
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentAmount.Location = new System.Drawing.Point(0, 50);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(42, 17);
            this.labelPaymentAmount.TabIndex = 2;
            this.labelPaymentAmount.Text = "Fiyat:";
            // 
            // textBoxPaymentAmount
            // 
            this.textBoxPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPaymentAmount.Location = new System.Drawing.Point(50, 50);
            this.textBoxPaymentAmount.Name = "textBoxPaymentAmount";
            this.textBoxPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxPaymentAmount.TabIndex = 3;
            // 
            // panelMeeting
            // 
            this.panelMeeting.Controls.Add(this.labelMeetingDate);
            this.panelMeeting.Controls.Add(this.dateTimePickerMeetingDate);
            this.panelMeeting.Controls.Add(this.labelMeetingPlace);
            this.panelMeeting.Controls.Add(this.textBoxMeetingPlace);
            this.panelMeeting.Controls.Add(this.labelMeetingTopic);
            this.panelMeeting.Controls.Add(this.textBoxMeetingTopic);
            this.panelMeeting.Location = new System.Drawing.Point(30, 150);
            this.panelMeeting.Name = "panelMeeting";
            this.panelMeeting.Size = new System.Drawing.Size(300, 120);
            this.panelMeeting.TabIndex = 10;
            this.panelMeeting.Visible = false;
            // 
            // labelMeetingDate
            // 
            this.labelMeetingDate.AutoSize = true;
            this.labelMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMeetingDate.Location = new System.Drawing.Point(0, 0);
            this.labelMeetingDate.Name = "labelMeetingDate";
            this.labelMeetingDate.Size = new System.Drawing.Size(47, 17);
            this.labelMeetingDate.TabIndex = 0;
            this.labelMeetingDate.Text = "Tarih:";
            // 
            // dateTimePickerMeetingDate
            // 
            this.dateTimePickerMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerMeetingDate.Location = new System.Drawing.Point(0, 20);
            this.dateTimePickerMeetingDate.Name = "dateTimePickerMeetingDate";
            this.dateTimePickerMeetingDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerMeetingDate.TabIndex = 1;
            // 
            // labelMeetingPlace
            // 
            this.labelMeetingPlace.AutoSize = true;
            this.labelMeetingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMeetingPlace.Location = new System.Drawing.Point(0, 50);
            this.labelMeetingPlace.Name = "labelMeetingPlace";
            this.labelMeetingPlace.Size = new System.Drawing.Size(34, 17);
            this.labelMeetingPlace.TabIndex = 2;
            this.labelMeetingPlace.Text = "Yer:";
            // 
            // textBoxMeetingPlace
            // 
            this.textBoxMeetingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMeetingPlace.Location = new System.Drawing.Point(50, 50);
            this.textBoxMeetingPlace.Name = "textBoxMeetingPlace";
            this.textBoxMeetingPlace.Size = new System.Drawing.Size(100, 23);
            this.textBoxMeetingPlace.TabIndex = 3;
            // 
            // labelMeetingTopic
            // 
            this.labelMeetingTopic.AutoSize = true;
            this.labelMeetingTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMeetingTopic.Location = new System.Drawing.Point(0, 80);
            this.labelMeetingTopic.Name = "labelMeetingTopic";
            this.labelMeetingTopic.Size = new System.Drawing.Size(48, 17);
            this.labelMeetingTopic.TabIndex = 4;
            this.labelMeetingTopic.Text = "Konu:";
            // 
            // textBoxMeetingTopic
            // 
            this.textBoxMeetingTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMeetingTopic.Location = new System.Drawing.Point(50, 80);
            this.textBoxMeetingTopic.Name = "textBoxMeetingTopic";
            this.textBoxMeetingTopic.Size = new System.Drawing.Size(100, 23);
            this.textBoxMeetingTopic.TabIndex = 5;
            // 
            // panelAnnouncement
            // 
            this.panelAnnouncement.Controls.Add(this.labelAnnouncementTopic);
            this.panelAnnouncement.Controls.Add(this.textBoxAnnouncementTopic);
            this.panelAnnouncement.Location = new System.Drawing.Point(30, 150);
            this.panelAnnouncement.Name = "panelAnnouncement";
            this.panelAnnouncement.Size = new System.Drawing.Size(300, 80);
            this.panelAnnouncement.TabIndex = 11;
            this.panelAnnouncement.Visible = false;
            // 
            // labelAnnouncementTopic
            // 
            this.labelAnnouncementTopic.AutoSize = true;
            this.labelAnnouncementTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAnnouncementTopic.Location = new System.Drawing.Point(0, 0);
            this.labelAnnouncementTopic.Name = "labelAnnouncementTopic";
            this.labelAnnouncementTopic.Size = new System.Drawing.Size(48, 17);
            this.labelAnnouncementTopic.TabIndex = 0;
            this.labelAnnouncementTopic.Text = "Konu:";
            // 
            // textBoxAnnouncementTopic
            // 
            this.textBoxAnnouncementTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAnnouncementTopic.Location = new System.Drawing.Point(50, 0);
            this.textBoxAnnouncementTopic.Name = "textBoxAnnouncementTopic";
            this.textBoxAnnouncementTopic.Size = new System.Drawing.Size(100, 23);
            this.textBoxAnnouncementTopic.TabIndex = 1;
            // 
            // NotificationForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panelAnnouncement);
            this.Controls.Add(this.panelMeeting);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.labelNotificationType);
            this.Controls.Add(this.comboBoxNotificationType);
            this.Controls.Add(this.buttonSendNotification);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.checkBoxAllUsers);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "NotificationForm";
            this.Text = "Bildirim Gönder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.CheckBox checkBoxAllUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonSendNotification;
        private System.Windows.Forms.ComboBox comboBoxNotificationType;
        private System.Windows.Forms.Label labelNotificationType;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label labelPaymentDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDueDate;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TextBox textBoxPaymentAmount;
        private System.Windows.Forms.Panel panelMeeting;
        private System.Windows.Forms.Label labelMeetingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMeetingDate;
        private System.Windows.Forms.Label labelMeetingPlace;
        private System.Windows.Forms.TextBox textBoxMeetingPlace;
        private System.Windows.Forms.Label labelMeetingTopic;
        private System.Windows.Forms.TextBox textBoxMeetingTopic;
        private System.Windows.Forms.Panel panelAnnouncement;
        private System.Windows.Forms.Label labelAnnouncementTopic;
        private System.Windows.Forms.TextBox textBoxAnnouncementTopic;
    }
}
