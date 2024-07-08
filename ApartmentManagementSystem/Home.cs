using System;
using System.Linq;
using System.Windows.Forms;
using ApartmentManagementSystem.BusinessLogic;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentManagementSystem
{
    public partial class Home : Form
    {
        private readonly ApartmentManagementContext _context;
        private readonly IServiceProvider _serviceProvider;
        private readonly int _userId;

        public Home(ApartmentManagementContext context, IServiceProvider serviceProvider, int userId)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            _userId = userId;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadUserData();
            LoadApartments();
        }

        private void LoadUserData()
        {
            User user = _context.Users.SingleOrDefault(u => u.UserID == _userId);
            if (user != null)
            {
                labelWelcome.Text = $"Hoşgeldiniz, {user.Username}";
            }
            else
            {
                labelWelcome.Text = "Kullanıcı bulunamadı.";
            }
        }

        private void LoadApartments()
        {
            var apartments = _context.Apartments.ToList();
            panelApartments.Controls.Clear();

            foreach (var apartment in apartments)
            {
                var apartmentBox = new Panel
                {
                    Width = 450,
                    Height = 150,
                    Margin = new Padding(10),
                    BackColor = System.Drawing.Color.LightSteelBlue,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var labelTitle = new Label
                {
                    Text = $"Daire {apartment.ApartmentNumber}",
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(10, 10),
                    AutoSize = true
                };

                var labelFloor = new Label
                {
                    Text = $"Kat: {apartment.Floor}",
                    Location = new System.Drawing.Point(10, 40),
                    AutoSize = true
                };

                var labelBlock = new Label
                {
                    Text = $"Blok: {apartment.Block}",
                    Location = new System.Drawing.Point(10, 60),
                    AutoSize = true
                };

                var buttonDetails = new Button
                {
                    Text = "Detaylar",
                    Location = new System.Drawing.Point(250, 100),
                    BackColor = System.Drawing.Color.RoyalBlue,
                    ForeColor = System.Drawing.Color.White,
                    Width = 80,
                    Height = 30
                };
                buttonDetails.Click += (s, e) => ShowApartmentDetails(apartment.ApartmentID);

                var buttonDelete = new Button
                {
                    Text = "Sil",
                    Location = new System.Drawing.Point(350, 100),
                    BackColor = System.Drawing.Color.Crimson,
                    ForeColor = System.Drawing.Color.White,
                    Width = 80,
                    Height = 30
                };
                buttonDelete.Click += (s, e) => DeleteApartment(apartment.ApartmentID);

                apartmentBox.Controls.Add(labelTitle);
                apartmentBox.Controls.Add(labelFloor);
                apartmentBox.Controls.Add(labelBlock);
                apartmentBox.Controls.Add(buttonDetails);
                apartmentBox.Controls.Add(buttonDelete);
                panelApartments.Controls.Add(apartmentBox);
            }
        }

        private void ShowApartmentDetails(int apartmentId)
        {
            var apartmentDetailsForm = new ApartmentDetails(_context, apartmentId);
            apartmentDetailsForm.ShowDialog();
        }

        private void DeleteApartment(int apartmentId)
        {
            var users = _context.Users.Where(u => u.ApartmentId == apartmentId).ToList();
            if (users.Count == 0)
            {
                var apartment = _context.Apartments.SingleOrDefault(a => a.ApartmentID == apartmentId);
                if (apartment != null)
                {
                    _context.Apartments.Remove(apartment);
                    _context.SaveChanges();
                    MessageBox.Show("Daire başarıyla silindi.");
                    LoadApartments(); // Daire silindikten sonra listeyi güncelle
                }
            }
            else
            {
                MessageBox.Show("Bu dairede kayıtlı kullanıcılar bulunduğu için silinemez.");
            }
        }

        private void buttonAddApartment_Click(object sender, EventArgs e)
        {
            var addApartmentForm = new AddApartment(_context);
            addApartmentForm.ShowDialog();
            LoadApartments(); // Yeni daire eklendikten sonra daireleri yeniden yükle
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser(_context);
            addUserForm.ShowDialog();
        }

        private void buttonSendNotification_Click(object sender, EventArgs e)
        {
            var notificationService = _serviceProvider.GetRequiredService<NotificationService>();
            var notificationForm = new NotificationForm(notificationService, _context);
            notificationForm.ShowDialog();
        }

        private void buttonIncomeExpense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelir Gider Tablosu işlemi");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<Form1>();
            loginForm.Show();
        }
    }
}
