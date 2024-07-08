using System;
using System.Windows.Forms;
using ApartmentManagementSystem.DataAccess;
using Entities;

namespace ApartmentManagementSystem
{
    public partial class AddApartment : Form
    {
        private readonly ApartmentManagementContext _context;

        public AddApartment(ApartmentManagementContext context)
        {
            _context = context;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonAddApartment_Click(object sender, EventArgs e)
        {
            string apartmentNumber = textBoxApartmentNumber.Text;
            int floor;
            if (!int.TryParse(textBoxFloor.Text, out floor))
            {
                MessageBox.Show("Lütfen geçerli bir kat numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string block = textBoxBlock.Text;

            var apartment = new Apartment
            {
                ApartmentNumber = apartmentNumber,
                Floor = floor,
                Block = block
            };

            _context.Apartments.Add(apartment);
            _context.SaveChanges();

            MessageBox.Show("Daire başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
