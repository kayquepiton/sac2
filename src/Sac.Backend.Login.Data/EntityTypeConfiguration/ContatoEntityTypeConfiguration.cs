using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class ContatoEntityTypeConfiguration : IEntityTypeConfiguration<ContatoEntity>
{
    public void Configure(EntityTypeBuilder<ContatoEntity> builder)
    {
        builder.ToTable("Contatos");

        builder.HasKey(co => co.Id);

        builder.Property(co => co.Setor)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(co => co.PessoaResponsavel)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(co => co.EmailEmpresa)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(co => co.TelefoneEmpresa)
            .HasMaxLength(15);

        builder.Property(co => co.CelularEmpresa)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(co => co.EmailPessoal)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(co => co.TelefonePessoal)
            .HasMaxLength(15);

        builder.Property(co => co.CelularPessoal)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(co => co.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(co => co.Deletado)
            .HasDefaultValue(false); 
    }
}
