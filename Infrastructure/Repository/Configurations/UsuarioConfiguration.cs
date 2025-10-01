using Microsoft.EntityFrameworkCore;
using System;
using Core.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Repository.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(p => p.Guid);
            builder.Property(p => p.Guid).HasColumnType("int").ValueGeneratedNever().UseIdentityColumn();
            builder.Property(p => p.DataNascimento).HasColumnType("DATETIME").IsRequired();
            builder.Property(p => p.Nome).HasColumnType("STRING").IsRequired();
            builder.Property(p => p.Email).HasColumnType("STRING");
            builder.Property(p => p.SenhaHash).HasColumnType("STRING");
            builder.Property(p => p.UsuarioCriacao).HasColumnType("DATETIME").IsRequired();
        }
    }
}
