using System.Linq;
using System.Collections.Generic;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Infra.Data.Repositories.Interface;

namespace AppBioBackEnd.Infra.Data.Repositories
{
    public class UnidadeAulaRepository : RepositoryBase<UnidadeAula>, IUnidadeAulaRepository
    {
        public IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula)
        {
            return ((IEnumerable<UnidadeAula>)GetById(idAula)).Where(p => p.IdAula.Equals(idAula));
        }

        public IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade)
        {
            return ((IEnumerable<UnidadeAula>)GetById(idUnidade)).ToList();
        }
    }
}
