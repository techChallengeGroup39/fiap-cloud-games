using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Repository.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Usuario.Role");

            builder.HasKey(r => r.Guid);
            builder.Property(r => r.Guid).HasColumnType("UNIQUEIDENTIFIER");
            builder.Property(r => r.Nome).HasColumnType("NVARCHAR(100)").IsRequired().HasMaxLength(100);
            builder.Property(r => r.DataCriacao).HasColumnType("DATETIME").IsRequired();
            builder.Property(r => r.CriadoPor).HasColumnType("NVARCHAR(100)").IsRequired().HasMaxLength(100);
            builder.Property(r => r.Status).HasColumnType("INT").IsRequired();
        }
    }
}
