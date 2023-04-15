using MA.CursoMVC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace MA.CursoMVC.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .HasMaxLength(150)
                .IsRequired();

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(10);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.CEP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(100);

            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");
        }
    }
}
