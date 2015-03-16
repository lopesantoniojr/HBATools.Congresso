using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HBATools.Congresso.DataLayer
{
    public class Context : DbContext
    {
        public DbSet<Entities.Pessoa> Pessoa { get; set; }
        public DbSet<Entities.PessoaFisica> PessoaFisica { get; set; }
        public DbSet<Entities.PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Entities.Segmento> Segmento { get; set; }

        public Context() : base("connectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Entities.PessoaFisica>()
                .HasRequired(c => c.pessoa_juridica).WithMany(c => c.pessoa_fisica)
                .HasForeignKey(c => c.id_pessoa_juridica);

            modelBuilder.Entity<Entities.Segmento>()
                .HasMany(c => c.pessoa_juridica).WithRequired(c => c.segmento)
                .HasForeignKey(c => c.id_segmento);

            modelBuilder.Entity<Entities.PessoaJuridica>().Property(p => p.id).HasColumnName("id_pessoa");
            modelBuilder.Entity<Entities.PessoaFisica>().Property(p => p.id).HasColumnName("id_pessoa");
           
            base.OnModelCreating(modelBuilder);

        }

       

        
    }
}
