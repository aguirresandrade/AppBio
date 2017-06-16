using AppBioBackEnd.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace AppBioBackEnd.Infra.Data.Configuration
{
    public class AulaConfiguration: EntityTypeConfiguration<Aula>
    {
        public AulaConfiguration()
        {
            HasKey(t => t.IdAula);

            Property(t => t.DescricaoAula)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
