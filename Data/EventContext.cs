using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarEventWebApp.Models;

namespace CalendarEventWebApp.Data
{
    public class EventContext  : DbContext
        {
            public EventContext(DbContextOptions<EventContext> options) : base(options)
            {
            }

            public DbSet<EventDetails> EventDetails { get; set; }
            public DbSet<EventLocation> EventLocations { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<EventDetails>().ToTable("EventDetails");
                modelBuilder.Entity<EventLocation>().ToTable("EventLocation");
            }
        }
    }