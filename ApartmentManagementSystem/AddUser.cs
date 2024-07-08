using System;
using System.Linq;
using System.Windows.Forms;
using ApartmentManagementSystem.DataAccess;
using Entities;

namespace ApartmentManagementSystem
{
    public partial class AddUser : Form
    {
        private readonly ApartmentManagementContext _context;

        public AddUser(ApartmentManagementContext context)
        {
            _context = context;
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

        private void AddUser_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // Daire numaralarını yükle
            var apartments = _context.Apartments.ToList();
            comboBoxApartment.DataSource = apartments;
            comboBoxApartment.DisplayMember = "ApartmentNumber";
            comboBoxApartment.ValueMember = "ApartmentID";
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int apartmentId = (int)comboBoxApartment.SelectedValue;
            string role = comboBoxRole.SelectedItem.ToString() == "Ev Sahibi" ? "Owner" : "Tenant";

            var user = new User
            {
                Username = username,
                Password = password,
                Name = name,
                Surname = surname,
                ApartmentId = apartmentId,
                Role = role
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Kullanıcı başarıyla eklendi.");
            this.Close();
        }
    }
}
