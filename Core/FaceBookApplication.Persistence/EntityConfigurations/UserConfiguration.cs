using FaceBookApplication.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaceBookApplication.Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(a => a.Friends).WithOne(a => a.User).HasForeignKey(a => a.UserId);
            builder.HasMany(a => a.Posts).WithOne(a => a.User).HasForeignKey(a => a.UserId);
        }
    }
}
