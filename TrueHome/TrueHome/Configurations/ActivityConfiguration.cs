using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueHome.Entities;

namespace TrueHome.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Status)
                .IsRequired();

            builder.Property<string>(p => p.Title)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            builder.HasOne(t => t.Property)
                .WithMany();

        }
    }
}
