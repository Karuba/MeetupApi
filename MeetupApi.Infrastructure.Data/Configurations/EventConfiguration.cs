
using MeetupApi.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
                new Event
                {
                    Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                    Name = "Technical screening",
                    Description = "A quick test of your technical skills",
                    Date = DateTime.Now,
                    Location = "At home",
                    OrganizerId = new Guid("01abbca8-664d-4b20-b5de-024705497d4b")
                }    
            );
        }
    }
}
