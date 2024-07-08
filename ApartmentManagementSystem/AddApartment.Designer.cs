namespace ApartmentManagementSystem
{
    partial class AddApartment
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
            this.textBoxApartmentNumber = new System.Windows.Forms.TextBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.labelBlock = new System.Windows.Forms.Label();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.buttonAddApartment = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApartmentNumber
            // 
            this.labelApartmentNumber.AutoSize = true;
            this.labelApartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApartmentNumber.Location = new System.Drawing.Point(50, 50);
            this.labelApartmentNumber.Name = "labelApartmentNumber";
            this.labelApartmentNumber.Size = new System.Drawing.Size(116, 17);
            this.labelApartmentNumber.TabIndex = 0;
            this.labelApartmentNumber.Text = "Daire Numarası:";
            // 
            // textBoxApartmentNumber
            // 
            this.textBoxApartmentNumber.Location = new System.Drawing.Point(200, 47);
            this.textBoxApartmentNumber.Name = "textBoxApartmentNumber";
            this.textBoxApartmentNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxApartmentNumber.TabIndex = 1;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloor.Location = new System.Drawing.Point(50, 100);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(34, 17);
            this.labelFloor.TabIndex = 2;
            this.labelFloor.Text = "Kat:";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(200, 97);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(200, 20);
            this.textBoxFloor.TabIndex = 3;
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlock.Location = new System.Drawing.Point(50, 150);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(41, 17);
            this.labelBlock.TabIndex = 4;
            this.labelBlock.Text = "Blok:";
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Location = new System.Drawing.Point(200, 147);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(200, 20);
            this.textBoxBlock.TabIndex = 5;
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddApartment.ForeColor = System.Drawing.Color.White;
            this.buttonAddApartment.Location = new System.Drawing.Point(200, 200);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(100, 30);
            this.buttonAddApartment.TabIndex = 6;
            this.buttonAddApartment.Text = "Daire Ekle";
            this.buttonAddApartment.UseVisualStyleBackColor = false;
            this.buttonAddApartment.Click += new System.EventHandler(this.buttonAddApartment_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.Controls.Add(this.labelApartmentNumber);
            this.panelMain.Controls.Add(this.buttonAddApartment);
            this.panelMain.Controls.Add(this.textBoxApartmentNumber);
            this.panelMain.Controls.Add(this.textBoxBlock);
            this.panelMain.Controls.Add(this.labelFloor);
            this.panelMain.Controls.Add(this.labelBlock);
            this.panelMain.Controls.Add(this.textBoxFloor);
            this.panelMain.Location = new System.Drawing.Point(100, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 300);
            this.panelMain.TabIndex = 7;
            // 
            // AddApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "AddApartment";
            this.Text = "Daire Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelApartmentNumber;
        private System.Windows.Forms.TextBox textBoxApartmentNumber;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.Button buttonAddApartment;
        private System.Windows.Forms.Panel panelMain;
    }
}
