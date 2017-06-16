using AppBioBackEnd.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace AppBioBackEnd.Infra.Data.Configuration
{
    public class UnidadeAulaConfiguration: EntityTypeConfiguration<UnidadeAula>
    {
        public UnidadeAulaConfiguration()
        {
            HasKey(t => new { t.IdUnidade, t.IdAula });

            Property(t => t.DataAula)
                .IsRequired();

            Property(t => t.DiaSemanaAula)
                .IsRequired();

            Property(t => t.HoraAula)
                .IsRequired();

            HasRequired(t => t.Unidade)
                .WithMany()
                .HasForeignKey(t => t.IdUnidade);

            HasRequired(t => t.Aula)
                .WithMany()
                .HasForeignKey(t => t.IdAula);
        }
    }
}
