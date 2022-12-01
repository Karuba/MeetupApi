using MeetupApi.Domain.Core.Entities;
using MeetupApi.Infrastructure.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeetupApi.Infrastructure.Data
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            
            model.ApplyConfiguration(new OrganizerConfiguration());
            model.ApplyConfiguration(new EventConfiguration());
            model.ApplyConfiguration(new PlanConfiguration());
            model.ApplyConfiguration(new SpeakerConfiguration());
            model.ApplyConfiguration(new EventSpeakerConfiguration());

            model.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
    }
}