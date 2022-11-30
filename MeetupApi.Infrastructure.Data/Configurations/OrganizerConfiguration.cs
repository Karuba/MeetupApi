
using MeetupApi.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasData(
                new Organizer
                {
                    Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4b"),
                    Name = "Ilya"
                }    
            );;
        }
    }
}
