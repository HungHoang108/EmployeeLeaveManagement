using EmployeeLeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeLeaveManagement.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
        new IdentityUserRole<string>
        {
            RoleId = "cac43a6e-f7bb-4448-baaf-lad431ccbbf",
            UserId = "cac43a6n-f7bb-4448-baaf-lad431ccbbf"
        },
                new IdentityUserRole<string>
                {
                    RoleId = "cac44a6e-f7nb-5448-bbaf-lad631ccbbf",
                    UserId = "cac53a6n-f7cb-4448-baaf-lad431ccbbf"
                }

        );
        }
    }
}