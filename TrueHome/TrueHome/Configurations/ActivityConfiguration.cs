using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueHome.Entities;

namespace TrueHome.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            _ = builder.ToTable("Activity");
            _ = builder.HasKey(x => x.Id);

            _ = builder.Property(p => p.Status)
                .HasColumnType("VARCHAR(35)")
                .IsRequired();

            _ = builder.Property(p => p.Title)
                .IsRequired();

            _ = builder.Property(p => p.StatudId)
                .IsRequired();

            _ = builder.HasOne(t => t.Property)
                .WithMany();

        }
    }
}
