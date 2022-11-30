
using MeetupApi.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetupApi.Infrastructure.Data.Configurations
{
    public class EventSpeakerConfiguration : IEntityTypeConfiguration<EventSpeaker>
    {
        public void Configure(EntityTypeBuilder<EventSpeaker> builder)
        {
            builder.HasKey(opt => new { opt.EventId, opt.SpeakerId });

            builder.HasOne(opt => opt.Event)
                .WithMany(@event => @event.EventSpeakers)
                .HasForeignKey(eventSpeaker => eventSpeaker.EventId);

            builder.HasOne(opt => opt.Speaker)
                .WithMany(speaker => speaker.EventSpeakers)
                .HasForeignKey(eventSpeaker => eventSpeaker.SpeakerId);

            builder.HasData(
                new EventSpeaker
                {
                    EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                    SpeakerId = new Guid("01abbca8-664d-4b20-b5de-024705497d4d")
                },
                new EventSpeaker
                {
                    EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                    SpeakerId = new Guid("02abbca8-664d-4b20-b5de-024705497d4d")
                }
            );
        }
    }
}
