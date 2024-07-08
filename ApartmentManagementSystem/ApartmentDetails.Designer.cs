namespace ApartmentManagementSystem
{
    partial class ApartmentDetails
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
            this.labelApartmentNumber = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelBlock = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApartmentNumber
            // 
            this.labelApartmentNumber.AutoSize = true;
            this.labelApartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApartmentNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelApartmentNumber.Location = new System.Drawing.Point(20, 20);
            this.labelApartmentNumber.Name = "labelApartmentNumber";
            this.labelApartmentNumber.Size = new System.Drawing.Size(139, 20);
            this.labelApartmentNumber.TabIndex = 0;
            this.labelApartmentNumber.Text = "Daire Numarası:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelFloor.Location = new System.Drawing.Point(20, 60);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(32, 17);
            this.labelFloor.TabIndex = 1;
            this.labelFloor.Text = "Kat:";
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlock.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelBlock.Location = new System.Drawing.Point(20, 100);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(40, 17);
            this.labelBlock.TabIndex = 2;
            this.labelBlock.Text = "Blok:";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUsers.Location = new System.Drawing.Point(20, 140);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(71, 17);
            this.labelUsers.TabIndex = 3;
            this.labelUsers.Text = "Kullanıcılar:";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.Azure;
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(20, 160);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(360, 340);
            this.listBoxUsers.TabIndex = 4;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(20, 510);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(360, 30);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Kullanıcıyı/Aile Üyesini Sil";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightCyan;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.labelApartmentNumber);
            this.panelMain.Controls.Add(this.buttonDeleteUser);
            this.panelMain.Controls.Add(this.listBoxUsers);
            this.panelMain.Controls.Add(this.labelFloor);
            this.panelMain.Controls.Add(this.labelUsers);
            this.panelMain.Controls.Add(this.labelBlock);
            this.panelMain.Location = new System.Drawing.Point(20, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(400, 560);
            this.panelMain.TabIndex = 5;
            // 
            // ApartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 600);
            this.Controls.Add(this.panelMain);
            this.Name = "ApartmentDetails";
            this.Text = "Daire Detayları";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelApartmentNumber;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Panel panelMain;
    }
}
