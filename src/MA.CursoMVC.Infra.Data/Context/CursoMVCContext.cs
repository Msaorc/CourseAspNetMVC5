using MA.CursoMVC.Domain.Entities;
using MA.CursoMVC.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MA.CursoMVC.Infra.Data.Context
{
    public class CursoMVCContext : DbContext
    {
        public CursoMVCContext()
            : base("ConnectionCurso")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
