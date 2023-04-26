using FaceBookApplication.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaceBookApplication.Persistence.EntityConfigurations
{
    public class BlokedConfiguration : IEntityTypeConfiguration<Bloked>
    {
        public void Configure(EntityTypeBuilder<Bloked> builder)
        {

        }
    }
}
