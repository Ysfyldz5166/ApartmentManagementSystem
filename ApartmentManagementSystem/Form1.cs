using System;
using System.Linq;
using System.Windows.Forms;
using ApartmentManagementSystem.BusinessLogic;
using ApartmentManagementSystem.DataAccess;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly ApartmentManagementContext _context;
        private readonly IServiceProvider _serviceProvider;

        public Form1(ApartmentManagementContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Form1_Resize);
            CenterPanel();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panelMain.Location = new System.Drawing.Point(
                (this.ClientSize.Width - panelMain.Width) / 2,
                (this.ClientSize.Height - panelMain.Height) / 2
            );
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriþ baþarýlý!");

                // Kullanýcý rolüne göre yönlendirme yap
                if (user.Role == "Admin")
                {
                    var homeForm = new Home(
                        _context,
                        _serviceProvider,
                        user.UserID);
                    homeForm.Show();
                }
                else
                {
                    var userHomeForm = new UserHome(
                        _serviceProvider.GetRequiredService<FamilyMemberService>(),
                        _serviceProvider.GetRequiredService<NotificationService>(),
                        _context,
                        _serviceProvider,
                        user.UserID);
                    userHomeForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
