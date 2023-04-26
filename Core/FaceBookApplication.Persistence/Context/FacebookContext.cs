using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace FaceBookApplication.Persistence.Context
{
    public class FacebookContext : DbContext
    {
        public FacebookContext(DbContextOptions<FacebookContext> options) : base(options)
        {

        }
        public DbSet<Request> Requests => this.Set<Request>();
        public DbSet<User>? Users => this.Set<User>();
        public DbSet<Post> Posts => this.Set<Post>();
        public DbSet<Notification> Notifications => this.Set<Notification>();
        public DbSet<Like> Likes => this.Set<Like>();
        public DbSet<Comment> Comments => this.Set<Comment>();
        public DbSet<Bloked> Blokeds => this.Set<Bloked>();
        public DbSet<Friend> Friends => this.Set<Friend>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }

    
}
