using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ApartmentManagementSystem.DataAccess
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApartmentManagementContext>
    {
        public ApartmentManagementContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApartmentManagementContext>();
            optionsBuilder.UseSqlServer("Server=YUSUFYILDIZ;Database=ApartmenManagementDb;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

            return new ApartmentManagementContext(optionsBuilder.Options);
        }
    }
}
