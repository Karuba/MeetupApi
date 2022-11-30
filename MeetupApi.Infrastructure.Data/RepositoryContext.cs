using MeetupApi.Domain.Core.Entities;
using MeetupApi.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MeetupApi.Infrastructure.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            //base.OnModelCreating(model);
            model.ApplyConfiguration(new OrganizerConfiguration());
            model.ApplyConfiguration(new EventConfiguration());
            model.ApplyConfiguration(new PlanConfiguration());
            model.ApplyConfiguration(new SpeakerConfiguration());
            model.ApplyConfiguration(new EventSpeakerConfiguration());
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
    }
}