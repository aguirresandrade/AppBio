using AppBioBackEnd.Domain.Entity;
using System.Collections.Generic;

namespace AppBioBackEnd.Application.Interfaces
{
    public interface IUnidadeAulaApplication: IApplicationBase<UnidadeAula>
    {
        IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade);
        IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula);
    }
}
