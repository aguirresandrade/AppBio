using AppBioBackEnd.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace AppBioBackEnd.Infra.Data.Configuration
{
    public class UnidadeConfiguration: EntityTypeConfiguration<Unidade>
    {
        public UnidadeConfiguration()
        {
            HasKey(t => t.IdUnidade);

            Property(t => t.NomeUnidade)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
