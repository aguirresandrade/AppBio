using System.Collections.Generic;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Services.Interfaces;
using AppBioBackEnd.Infra.Data.Repositories.Interface;

namespace AppBioBackEnd.Services
{
    public class UnidadeAulaService: ServiceBase<UnidadeAula>, IUnidadeAulaService
    {
        private readonly IUnidadeAulaRepository _repository;                         

        public UnidadeAulaService(IUnidadeAulaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<UnidadeAula> ObterDadosPorAula(int idAula)
        {
            return _repository.ObterDadosPorAula(idAula);
        }

        public IEnumerable<UnidadeAula> ObterDadosPorUnidade(int idUnidade)
        {
            return _repository.ObterDadosPorUnidade(idUnidade);
        }
    }
}
