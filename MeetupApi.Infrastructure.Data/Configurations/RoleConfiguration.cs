
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "Participant",
                    NormalizedName = "PARTICIPANT"
                },
                new IdentityRole
                {
                    Name = "Organizer",
                    NormalizedName = "ORGANIZER"
                }
            );
        }
    }
}
