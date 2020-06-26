using Microsoft.EntityFrameworkCore;
using SocialMediaCore.Core.Entities;
using SocialMediaCore.Infrastructure.Data.Configurations;
using System.Diagnostics;

namespace SocialMediaCore.Infrastructure.Data
{
    public partial class SocialMediaDBContext : DbContext
    {
        public SocialMediaDBContext() { }

        public SocialMediaDBContext(DbContextOptions<SocialMediaDBContext> options) : base(options) { }

        public virtual DbSet<Coment> Coments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ComentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
