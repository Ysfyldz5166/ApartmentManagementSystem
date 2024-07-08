using System;
using System.Linq;
using System.Windows.Forms;
using ApartmentManagementSystem.DataAccess;

namespace ApartmentManagementSystem
{
    public partial class ApartmentDetails : Form
    {
        private readonly ApartmentManagementContext _context;
        private readonly int _apartmentId;

        public ApartmentDetails(ApartmentManagementContext context, int apartmentId)
        {
            _context = context;
            _apartmentId = apartmentId;
            InitializeComponent();
            LoadApartmentDetails();
        }

        private void LoadApartmentDetails()
        {
            var apartment = _context.Apartments.SingleOrDefault(a => a.ApartmentID == _apartmentId);
            if (apartment != null)
            {
                labelApartmentNumber.Text = $"Daire Numarası: {apartment.ApartmentNumber}";
                labelFloor.Text = $"Kat: {apartment.Floor}";
                labelBlock.Text = $"Blok: {apartment.Block}";

                // Load users and family members
                var users = _context.Users.Where(u => u.ApartmentId == _apartmentId).ToList();
                listBoxUsers.Items.Clear();
                foreach (var user in users)
                {
                    listBoxUsers.Items.Add(new ListBoxUserItem(user.Name, user.Surname, user.Username, user.UserID));

                    var familyMembers = _context.FamilyMembers.Where(f => f.ApartmentID == _apartmentId).ToList();
                    foreach (var member in familyMembers)
                    {
                        listBoxUsers.Items.Add(new ListBoxFamilyItem(member.Name, member.Surname, member.Role, member.FamilyMemberID));
                    }
                }
            }
            else
            {
                MessageBox.Show("Daire bulunamadı.");
                this.Close();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                var selectedItem = listBoxUsers.SelectedItem;
                if (selectedItem is ListBoxUserItem userItem)
                {
                    var user = _context.Users.SingleOrDefault(u => u.UserID == userItem.UserID);
                    if (user != null)
                    {
                        _context.Users.Remove(user);
                        _context.SaveChanges();
                        MessageBox.Show("Kullanıcı başarıyla silindi.");
                        LoadApartmentDetails(); // Kullanıcı silindikten sonra listeyi güncelle
                    }
                }
                else if (selectedItem is ListBoxFamilyItem familyItem)
                {
                    var familyMember = _context.FamilyMembers.SingleOrDefault(f => f.FamilyMemberID == familyItem.FamilyMemberID);
                    if (familyMember != null)
                    {
                        _context.FamilyMembers.Remove(familyMember);
                        _context.SaveChanges();
                        MessageBox.Show("Aile üyesi başarıyla silindi.");
                        LoadApartmentDetails(); // Aile üyesi silindikten sonra listeyi güncelle
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı veya aile üyesini seçin.");
            }
        }

        private class ListBoxUserItem
        {
            public string Name { get; }
            public string Surname { get; }
            public string Username { get; }
            public int UserID { get; }

            public ListBoxUserItem(string name, string surname, string username, int userId)
            {
                Name = name;
                Surname = surname;
                Username = username;
                UserID = userId;
            }

            public override string ToString()
            {
                return $"{Name} {Surname} ({Username})";
            }
        }

        private class ListBoxFamilyItem
        {
            public string Name { get; }
            public string Surname { get; }
            public string Role { get; }
            public int FamilyMemberID { get; }

            public ListBoxFamilyItem(string name, string surname, string role, int familyMemberId)
            {
                Name = name;
                Surname = surname;
                Role = role;
                FamilyMemberID = familyMemberId;
            }

            public override string ToString()
            {
                return $"    {Name} {Surname} ({Role})";
            }
        }
    }
}
