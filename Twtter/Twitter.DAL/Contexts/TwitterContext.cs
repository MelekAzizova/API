using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Twitter.Core.Entities;
using Twitter.Core.Entities.Common;
using Twitter.DAL.Configuration;

namespace Twitter.DAL.Contexts
{
    public class TwitterContext:IdentityDbContext       
    {
        public TwitterContext(DbContextOptions opt) :base(opt)
        {
            
        }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<AppUser > AppUsers { get;set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.ApplyConfiguration<Topic>(new TopicConfirations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
