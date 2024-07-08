namespace ApartmentManagementSystem
{
    partial class AddUser
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelApartment = new System.Windows.Forms.Label();
            this.comboBoxApartment = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(50, 70);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 17);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Kullanıcı Adı:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(200, 67);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(50, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(42, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Şifre:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 107);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(50, 150);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Adı:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 147);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(50, 190);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(61, 17);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Soyadı:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(200, 187);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // labelApartment
            // 
            this.labelApartment.AutoSize = true;
            this.labelApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApartment.Location = new System.Drawing.Point(50, 230);
            this.labelApartment.Name = "labelApartment";
            this.labelApartment.Size = new System.Drawing.Size(85, 17);
            this.labelApartment.TabIndex = 8;
            this.labelApartment.Text = "Daire No:";
            // 
            // comboBoxApartment
            // 
            this.comboBoxApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApartment.FormattingEnabled = true;
            this.comboBoxApartment.Location = new System.Drawing.Point(200, 227);
            this.comboBoxApartment.Name = "comboBoxApartment";
            this.comboBoxApartment.Size = new System.Drawing.Size(200, 21);
            this.comboBoxApartment.TabIndex = 9;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(50, 270);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(42, 17);
            this.labelRole.TabIndex = 10;
            this.labelRole.Text = "Rol:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Ev Sahibi",
            "Kiracı"});
            this.comboBoxRole.Location = new System.Drawing.Point(200, 267);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRole.TabIndex = 11;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(200, 310);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 30);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "Kullanıcı Ekle";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.labelUsername);
            this.panelMain.Controls.Add(this.buttonAddUser);
            this.panelMain.Controls.Add(this.textBoxUsername);
            this.panelMain.Controls.Add(this.comboBoxRole);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.labelRole);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.comboBoxApartment);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.labelApartment);
            this.panelMain.Controls.Add(this.textBoxName);
            this.panelMain.Controls.Add(this.textBoxSurname);
            this.panelMain.Controls.Add(this.labelSurname);
            this.panelMain.Location = new System.Drawing.Point((this.ClientSize.Width - 500) / 2, (this.ClientSize.Height - 450) / 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 450);
            this.panelMain.TabIndex = 13;
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(200, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 24);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Kullanıcı Ekle";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "AddUser";
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.Resize += new System.EventHandler(this.AddUser_Resize);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelApartment;
        private System.Windows.Forms.ComboBox comboBoxApartment;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
    }
}
