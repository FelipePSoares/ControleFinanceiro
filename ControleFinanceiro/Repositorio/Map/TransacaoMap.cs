using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Map
{
    public class TransacaoMap : EntityTypeConfiguration<Transacao>
    {
        public TransacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => (Int32)t.Opcao)
                .IsRequired();

            this.Property(t => t.Descricao)
                .IsRequired();

            this.Property(t => t.Valor)
                .IsRequired();

            this.Property(t => t.Data)
                .IsRequired();

            this.Property(t => (Int32)t.Importancia)
                .IsRequired();

            this.Property(t => t.DeduzDoImpostoDeRenda);
            
            this.Property(t => t.CpfCnpj)
                .IsOptional();
        }
    }
}
