using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<ClienteEntity>
{
    public void Configure(EntityTypeBuilder<ClienteEntity> builder)
    {
        builder.ToTable("Clientes");

        builder.HasKey(cl => cl.Id);

        builder.Property(cl => cl.Nome_RazaoSocial)
            .HasMaxLength(200);

        builder.Property(cl => cl.CPF_CNPJ)
            .HasMaxLength(14);

        builder.Property(cl => cl.EnderecoId)
            .IsRequired();

        builder.Property(cl => cl.ContatoId)
            .IsRequired();

        builder.Property(cl => cl.TipoPessoa)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(cl => cl.TipoCliente)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(cl => cl.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(cl => cl.Deletado)
            .HasDefaultValue(false); 

        builder.HasOne(e => e.Endereco)
            .WithOne(cl => cl.Cliente)
            .HasForeignKey<ClienteEntity>(cl => cl.EnderecoId);

        builder.HasOne(co => co.Contato)
            .WithOne(cl => cl.Cliente)
            .HasForeignKey<ClienteEntity>(cl => cl.ContatoId);
    }
}
