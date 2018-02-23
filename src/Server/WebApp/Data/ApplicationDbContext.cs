﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Govmeeting.Backend.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{

    // See here for extending this class:
    //   https://stackoverflow.com/a/40579369/1978840
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<GovernmentBody> GovernmentBodies { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<Govmeeting.Backend.Model.Talk> Talks { get; set; }

        public DbSet<TopicDiscussion> TopicDiscussions { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Representative> Representatives { get; set; }

        public DbSet<Citizen> Citizens { get; set; }

        public DbSet<Language> Languages { get; set; }

    }
}
