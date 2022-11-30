﻿// <auto-generated />
using System;
using MeetupApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeetupApi.Infrastructure.Migr.SqlServer.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("OrganizerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                            Date = new DateTime(2022, 11, 30, 21, 58, 39, 173, DateTimeKind.Local).AddTicks(1574),
                            Description = "A quick test of your technical skills",
                            Location = "At home",
                            Name = "Technical screening",
                            OrganizerId = new Guid("01abbca8-664d-4b20-b5de-024705497d4b")
                        });
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.EventSpeaker", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SpeakerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventId", "SpeakerId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventSpeakers");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                            SpeakerId = new Guid("01abbca8-664d-4b20-b5de-024705497d4d")
                        });
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Organizer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Organizer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4b"),
                            Name = "Ilya"
                        });
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Plan");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                            Description = "Ask questions",
                            EventId = new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                            Time = new DateTime(2022, 11, 30, 21, 58, 39, 173, DateTimeKind.Local).AddTicks(1653)
                        });
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Speaker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Speaker");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01abbca8-664d-4b20-b5de-024705497d4d"),
                            Name = "Dmitry"
                        });
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Event", b =>
                {
                    b.HasOne("MeetupApi.Domain.Core.Entities.Organizer", "Organizer")
                        .WithMany("Events")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.EventSpeaker", b =>
                {
                    b.HasOne("MeetupApi.Domain.Core.Entities.Event", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetupApi.Domain.Core.Entities.Speaker", "Speaker")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Plan", b =>
                {
                    b.HasOne("MeetupApi.Domain.Core.Entities.Event", "Event")
                        .WithMany("Plans")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Event", b =>
                {
                    b.Navigation("EventSpeakers");

                    b.Navigation("Plans");
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Organizer", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("MeetupApi.Domain.Core.Entities.Speaker", b =>
                {
                    b.Navigation("EventSpeakers");
                });
#pragma warning restore 612, 618
        }
    }
}
