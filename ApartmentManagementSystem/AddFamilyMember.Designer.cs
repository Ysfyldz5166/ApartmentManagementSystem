namespace ApartmentManagementSystem
{
    partial class AddFamilyMember
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
            this.buttonAddFamilyMember = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonAddFamilyMember);
            this.panelMain.Controls.Add(this.numericUpDownAge);
            this.panelMain.Controls.Add(this.labelAge);
            this.panelMain.Controls.Add(this.textBoxSurname);
            this.panelMain.Controls.Add(this.labelSurname);
            this.panelMain.Controls.Add(this.textBoxName);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(400, 300);
            this.panelMain.TabIndex = 0;
            // 
            // buttonAddFamilyMember
            // 
            this.buttonAddFamilyMember.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFamilyMember.ForeColor = System.Drawing.Color.White;
            this.buttonAddFamilyMember.Location = new System.Drawing.Point(150, 200);
            this.buttonAddFamilyMember.Name = "buttonAddFamilyMember";
            this.buttonAddFamilyMember.Size = new System.Drawing.Size(100, 30);
            this.buttonAddFamilyMember.TabIndex = 6;
            this.buttonAddFamilyMember.Text = "Aile Üyesi Ekle";
            this.buttonAddFamilyMember.UseVisualStyleBackColor = false;
            this.buttonAddFamilyMember.Click += new System.EventHandler(this.buttonAddFamilyMember_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownAge.Location = new System.Drawing.Point(150, 140);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownAge.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAge.Location = new System.Drawing.Point(100, 140);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(34, 17);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Yaş:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSurname.Location = new System.Drawing.Point(150, 100);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(120, 23);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSurname.Location = new System.Drawing.Point(60, 100);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(65, 17);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Soyisim:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.Location = new System.Drawing.Point(150, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(80, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "İsim:";
            // 
            // AddFamilyMember
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "AddFamilyMember";
            this.Text = "Aile Üyesi Ekle";
            this.Resize += new System.EventHandler(this.AddFamilyMember_Resize);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonAddFamilyMember;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}
