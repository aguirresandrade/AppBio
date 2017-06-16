using AppBioBackEnd.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace AppBioBackEnd.Infra.Data.Configuration
{
    public class AlunoConfiguration : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfiguration()
        {
            HasKey(t => t.IdAluno);

            Property(t => t.NomeAluno)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.EmailAluno)
                .HasMaxLength(200);

            Property(t => t.PerfilFacebook)
                .HasMaxLength(100);

            Property(t => t.DataNascimento);
        }
    }
}
