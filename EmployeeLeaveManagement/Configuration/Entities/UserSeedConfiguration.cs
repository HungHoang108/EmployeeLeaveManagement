using EmployeeLeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeLeaveManagement.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
            
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
        new Employee
            {
                Id = "cac43a6n-f7bb-4448-baaf-lad431ccbbf",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                Firstname = "System",
                Lastname = "Admin",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
        },

                new Employee
                {
                    Id = "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName= "user@localhost.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }

        );
        }
    }
}