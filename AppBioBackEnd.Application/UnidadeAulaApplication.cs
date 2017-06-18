using System.Collections.Generic;
using AppBioBackEnd.Application.Interfaces;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Application
{
    public class UnidadeAulaApplication: ApplicationBase<UnidadeAula>, IUnidadeAulaApplication
    {
        private readonly IUnidadeAulaService _service;

        public UnidadeAulaApplication(IUnidadeAulaService service)
            :base(service)
        {
            _service = service;
        }

        public IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula)
        {
            return _service.ObterDadosPorAula(idAula);
        }

        public IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade)
        {
            return _service.ObterDadosPorUnidade(idUnidade);
        }
    }
}
