namespace ApartmentManagementSystem
{
    partial class UserHome
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonViewNotifications = new System.Windows.Forms.Button();
            this.buttonViewAnnouncements = new System.Windows.Forms.Button();
            this.buttonViewPersonalInfo = new System.Windows.Forms.Button();
            this.buttonAddFamilyMember = new System.Windows.Forms.Button(); // Yeni buton
            this.buttonLogout = new System.Windows.Forms.Button(); // Çıkış Yap butonu
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(270, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(145, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Hoşgeldiniz, ";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.buttonViewNotifications);
            this.panelMenu.Controls.Add(this.buttonViewAnnouncements);
            this.panelMenu.Controls.Add(this.buttonViewPersonalInfo);
            this.panelMenu.Controls.Add(this.buttonAddFamilyMember); // Yeni buton
            this.panelMenu.Controls.Add(this.buttonLogout); // Çıkış Yap butonu
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonViewNotifications
            // 
            this.buttonViewNotifications.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonViewNotifications.ForeColor = System.Drawing.Color.White;
            this.buttonViewNotifications.Location = new System.Drawing.Point(12, 100);
            this.buttonViewNotifications.Name = "buttonViewNotifications";
            this.buttonViewNotifications.Size = new System.Drawing.Size(220, 40);
            this.buttonViewNotifications.TabIndex = 0;
            this.buttonViewNotifications.Text = "Bildirimleri Görüntüle";
            this.buttonViewNotifications.UseVisualStyleBackColor = false;
            this.buttonViewNotifications.Click += new System.EventHandler(this.buttonViewNotifications_Click);
            // 
            // buttonViewAnnouncements
            // 
            this.buttonViewAnnouncements.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonViewAnnouncements.ForeColor = System.Drawing.Color.White;
            this.buttonViewAnnouncements.Location = new System.Drawing.Point(12, 160);
            this.buttonViewAnnouncements.Name = "buttonViewAnnouncements";
            this.buttonViewAnnouncements.Size = new System.Drawing.Size(220, 40);
            this.buttonViewAnnouncements.TabIndex = 1;
            this.buttonViewAnnouncements.Text = "Duyuruları Görüntüle";
            this.buttonViewAnnouncements.UseVisualStyleBackColor = false;
            this.buttonViewAnnouncements.Click += new System.EventHandler(this.buttonViewAnnouncements_Click);
            // 
            // buttonViewPersonalInfo
            // 
            this.buttonViewPersonalInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonViewPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.buttonViewPersonalInfo.Location = new System.Drawing.Point(12, 220);
            this.buttonViewPersonalInfo.Name = "buttonViewPersonalInfo";
            this.buttonViewPersonalInfo.Size = new System.Drawing.Size(220, 40);
            this.buttonViewPersonalInfo.TabIndex = 2;
            this.buttonViewPersonalInfo.Text = "Kişisel Bilgileri Görüntüle";
            this.buttonViewPersonalInfo.UseVisualStyleBackColor = false;
            this.buttonViewPersonalInfo.Click += new System.EventHandler(this.buttonViewPersonalInfo_Click);
            // 
            // buttonAddFamilyMember
            // 
            this.buttonAddFamilyMember.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddFamilyMember.ForeColor = System.Drawing.Color.White;
            this.buttonAddFamilyMember.Location = new System.Drawing.Point(12, 280);
            this.buttonAddFamilyMember.Name = "buttonAddFamilyMember";
            this.buttonAddFamilyMember.Size = new System.Drawing.Size(220, 40);
            this.buttonAddFamilyMember.TabIndex = 3;
            this.buttonAddFamilyMember.Text = "Aile Üyesi Ekle";
            this.buttonAddFamilyMember.UseVisualStyleBackColor = false;
            this.buttonAddFamilyMember.Click += new System.EventHandler(this.buttonAddFamilyMember_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Crimson;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(12, 340);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(220, 40);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Çıkış Yap";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panelMenu);
            this.Name = "UserHome";
            this.Text = "Kullanıcı Ana Sayfa";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonViewNotifications;
        private System.Windows.Forms.Button buttonViewAnnouncements;
        private System.Windows.Forms.Button buttonViewPersonalInfo;
        private System.Windows.Forms.Button buttonAddFamilyMember; // Yeni buton
        private System.Windows.Forms.Button buttonLogout; // Çıkış Yap butonu
    }
}
