using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using ApartmentManagementSystem.DataAccess;
using ApartmentManagementSystem.BusinessLogic;

namespace ApartmentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ServiceCollection olu�tur ve hizmetleri yap�land�r
            var services = new ServiceCollection();
            ConfigureServices(services);

            // ServiceProvider olu�tur
            var serviceProvider = services.BuildServiceProvider();

            // Uygulama yap�land�rmas�n� ba�lat
            ApplicationConfiguration.Initialize();

            // Form1'i serviceProvider'dan al�n ve uygulamay� ba�lat�n
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // DbContext'i yap�land�r
            services.AddDbContext<ApartmentManagementContext>(options =>
                options.UseSqlServer("Server=YUSUFYILDIZ;Database=ApartmenManagementDb;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True"));

            // Servisleri ekle
            services.AddTransient<UserService>();
            services.AddTransient<ApartmentService>();
            services.AddTransient<NotificationService>();
            services.AddTransient<ExpenseService>();
            services.AddTransient<IncomeService>();
            services.AddTransient<FamilyMemberService>();

            // Formlar� hizmet olarak ekle
            services.AddTransient<Form1>();
            services.AddTransient<Home>();
            services.AddTransient<UserHome>();
            services.AddTransient<AddApartment>();
            services.AddTransient<AddUser>();
            services.AddTransient<ApartmentDetails>();
            services.AddTransient<AddFamilyMember>();
            services.AddTransient<NotificationForm>();
        }
    }
}
