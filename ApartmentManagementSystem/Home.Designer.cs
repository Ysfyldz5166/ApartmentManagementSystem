namespace ApartmentManagementSystem
{
    partial class Home
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
            this.buttonAddApartment = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonSendNotification = new System.Windows.Forms.Button();
            this.buttonIncomeExpense = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelApartments = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panelMenu.Controls.Add(this.buttonAddApartment);
            this.panelMenu.Controls.Add(this.buttonAddUser);
            this.panelMenu.Controls.Add(this.buttonSendNotification);
            this.panelMenu.Controls.Add(this.buttonIncomeExpense);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddApartment.ForeColor = System.Drawing.Color.White;
            this.buttonAddApartment.Location = new System.Drawing.Point(12, 100);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(220, 40);
            this.buttonAddApartment.TabIndex = 0;
            this.buttonAddApartment.Text = "Daire Ekle";
            this.buttonAddApartment.UseVisualStyleBackColor = false;
            this.buttonAddApartment.Click += new System.EventHandler(this.buttonAddApartment_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(12, 160);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(220, 40);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Kullanıcı Ekle";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonSendNotification
            // 
            this.buttonSendNotification.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSendNotification.ForeColor = System.Drawing.Color.White;
            this.buttonSendNotification.Location = new System.Drawing.Point(12, 220);
            this.buttonSendNotification.Name = "buttonSendNotification";
            this.buttonSendNotification.Size = new System.Drawing.Size(220, 40);
            this.buttonSendNotification.TabIndex = 2;
            this.buttonSendNotification.Text = "İlan Gönder";
            this.buttonSendNotification.UseVisualStyleBackColor = false;
            this.buttonSendNotification.Click += new System.EventHandler(this.buttonSendNotification_Click);
            // 
            // buttonIncomeExpense
            // 
            this.buttonIncomeExpense.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIncomeExpense.ForeColor = System.Drawing.Color.White;
            this.buttonIncomeExpense.Location = new System.Drawing.Point(12, 280);
            this.buttonIncomeExpense.Name = "buttonIncomeExpense";
            this.buttonIncomeExpense.Size = new System.Drawing.Size(220, 40);
            this.buttonIncomeExpense.TabIndex = 3;
            this.buttonIncomeExpense.Text = "Gelir Gider Tablosu";
            this.buttonIncomeExpense.UseVisualStyleBackColor = false;
            this.buttonIncomeExpense.Click += new System.EventHandler(this.buttonIncomeExpense_Click);
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
            // panelApartments
            // 
            this.panelApartments.AutoScroll = true;
            this.panelApartments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelApartments.Location = new System.Drawing.Point(270, 70);
            this.panelApartments.Name = "panelApartments";
            this.panelApartments.Size = new System.Drawing.Size(500, 350);
            this.panelApartments.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelApartments);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Ana Sayfa";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAddApartment;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonSendNotification;
        private System.Windows.Forms.Button buttonIncomeExpense;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.FlowLayoutPanel panelApartments;
    }
}
