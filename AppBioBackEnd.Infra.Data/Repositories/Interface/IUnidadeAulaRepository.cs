using AppBioBackEnd.Domain.Entity;
using System.Collections.Generic;

namespace AppBioBackEnd.Infra.Data.Repositories.Interface
{
    public interface IUnidadeAulaRepository: IRepositoryBase<UnidadeAula>
    {
        IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade);
        IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula);
    }
}
