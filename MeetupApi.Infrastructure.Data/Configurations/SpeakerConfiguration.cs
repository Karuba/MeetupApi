
using MeetupApi.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class SpeakerConfiguration : IEntityTypeConfiguration<Speaker>
    {
        public void Configure(EntityTypeBuilder<Speaker> builder)
        {
            builder.HasData(
                new Speaker
                {
                    Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4d"),
                    Name = "Dmitry"
                },
                new Speaker
                {
                    Id = new Guid("02abbca8-664d-4b20-b5de-024705497d4d"),
                    Name = "Some man"
                }
            );
        }
    }
}
