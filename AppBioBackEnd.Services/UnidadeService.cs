using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Infra.Data.Repositories.Interface;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Services
{
    public class UnidadeService: ServiceBase<Unidade>, IUnidadeService
    {
        private readonly IUnidadeRepository _repository;

        public UnidadeService(IUnidadeRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
