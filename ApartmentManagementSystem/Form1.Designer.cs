namespace ApartmentManagementSystem
{
    partial class Form1
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.buttonLogin);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.textBoxUsername);
            this.panelMain.Controls.Add(this.labelUsername);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(400, 300);
            this.panelMain.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(150, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 26);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Giriş Yap";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(150, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 30);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(150, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(120, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPassword.Location = new System.Drawing.Point(80, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(38, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Şifre:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(150, 100);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(120, 23);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsername.Location = new System.Drawing.Point(40, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(78, 17);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
    }
}
