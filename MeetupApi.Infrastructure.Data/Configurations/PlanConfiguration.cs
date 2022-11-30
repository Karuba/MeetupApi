
using MeetupApi.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasData(
                new Plan
                {
                    Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                    Time = DateTime.Now,
                    Description = "Ask questions",
                    EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a")
                },
                new Plan
                {
                    Id = new Guid("02abbca8-664d-4b20-b5de-024705497d4c"),
                    Time = DateTime.Now,
                    Description = "Conclusion",
                    EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a")
                }
            );
        }
    }
}
