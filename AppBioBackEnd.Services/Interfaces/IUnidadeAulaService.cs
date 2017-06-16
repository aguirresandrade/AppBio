using AppBioBackEnd.Domain.Entity;
using System.Collections.Generic;

namespace AppBioBackEnd.Services.Interfaces
{
    public interface IUnidadeAulaService: IServiceBase<UnidadeAula>
    {
        IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade);
        IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula);
    }
}
