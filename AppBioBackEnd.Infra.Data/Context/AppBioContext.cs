using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Infra.Data.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AppBioBackEnd.Infra.Data.Context
{
    public class AppBioContext: DbContext
    {
        static AppBioContext()
        {
            Database.SetInitializer<AppBioContext>(null);
        }

        public AppBioContext()
            :base("Name=AppBioContext")
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<UnidadeAula> UnidadeAula { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AlunoConfiguration());
            modelBuilder.Configurations.Add(new AulaConfiguration());
            modelBuilder.Configurations.Add(new UnidadeConfiguration());
            modelBuilder.Configurations.Add(new UnidadeAulaConfiguration());

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}
