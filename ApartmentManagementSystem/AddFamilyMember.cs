using System;
using System.Windows.Forms;
using ApartmentManagementSystem.BusinessLogic;
using Entities;

namespace ApartmentManagementSystem
{
    public partial class AddFamilyMember : Form
    {
        private readonly FamilyMemberService _familyMemberService;
        private readonly int _apartmentId;

        public AddFamilyMember(FamilyMemberService familyMemberService, int apartmentId)
        {
            _familyMemberService = familyMemberService;
            _apartmentId = apartmentId;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CenterPanel();
        }

        private void CenterPanel()
        {
            panelMain.Location = new System.Drawing.Point(
                (this.ClientSize.Width - panelMain.Width) / 2,
                (this.ClientSize.Height - panelMain.Height) / 2
            );
        }

        private void AddFamilyMember_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void AddFamilyMember_Load(object sender, EventArgs e)
        {
            // Additional initialization can be done here
        }

        private void buttonAddFamilyMember_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                byte age = (byte)numericUpDownAge.Value;

                // Check for empty fields
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                var familyMember = new FamilyMember
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    ApartmentID = _apartmentId,
                    Role = "Family Member" // Setting default role
                };

                _familyMemberService.AddFamilyMember(familyMember);

                MessageBox.Show("Aile üyesi başarıyla eklendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                // Log or handle the error details
            }
        }
    }
}
