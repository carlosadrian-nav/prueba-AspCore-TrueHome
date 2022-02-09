using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueHome.Entities;

namespace TrueHome.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            _ = builder.ToTable("Property");
            _ = builder.HasKey(x => x.Id);

            _ = builder.Property(p => p.Status)
                .HasColumnType("VARCHAR(35)")
                .IsRequired();

            _ = builder.Property(p => p.Title)
                .HasColumnType("VARCHAR(255)")
                .IsRequired();

            _ = builder.Property(p => p.Description)
                .HasColumnType("text")
                .IsRequired();

            _ = builder.Property(p => p.StatudId)
                .IsRequired();


        }
    }
}
