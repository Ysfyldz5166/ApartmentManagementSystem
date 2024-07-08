namespace ApartmentManagementSystem
{
    partial class NotificationDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAttend;
        private System.Windows.Forms.Button buttonNotAttend;

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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAttend = new System.Windows.Forms.Button();
            this.buttonNotAttend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Başlık";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMessage.Location = new System.Drawing.Point(17, 50);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(355, 200);
            this.textBoxMessage.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDate.Location = new System.Drawing.Point(14, 260);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Tarih";
            // 
            // buttonAttend
            // 
            this.buttonAttend.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAttend.ForeColor = System.Drawing.Color.White;
            this.buttonAttend.Location = new System.Drawing.Point(17, 290);
            this.buttonAttend.Name = "buttonAttend";
            this.buttonAttend.Size = new System.Drawing.Size(100, 30);
            this.buttonAttend.TabIndex = 3;
            this.buttonAttend.Text = "Katılacağım";
            this.buttonAttend.UseVisualStyleBackColor = false;
            this.buttonAttend.Visible = false;
            this.buttonAttend.Click += new System.EventHandler(this.buttonAttend_Click);
            // 
            // buttonNotAttend
            // 
            this.buttonNotAttend.BackColor = System.Drawing.Color.Crimson;
            this.buttonNotAttend.ForeColor = System.Drawing.Color.White;
            this.buttonNotAttend.Location = new System.Drawing.Point(123, 290);
            this.buttonNotAttend.Name = "buttonNotAttend";
            this.buttonNotAttend.Size = new System.Drawing.Size(100, 30);
            this.buttonNotAttend.TabIndex = 4;
            this.buttonNotAttend.Text = "Katılmayacağım";
            this.buttonNotAttend.UseVisualStyleBackColor = false;
            this.buttonNotAttend.Visible = false;
            this.buttonNotAttend.Click += new System.EventHandler(this.buttonNotAttend_Click);
            // 
            // NotificationDetailForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.buttonNotAttend);
            this.Controls.Add(this.buttonAttend);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelTitle);
            this.Name = "NotificationDetailForm";
            this.Text = "Bildirim Detayları";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
