using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Infra.Data.Repositories.Interface;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Services
{
    public class AulaService: ServiceBase<Aula>, IAulaService
    {
        private readonly IAulaRepository _repository;

        public AulaService(IAulaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
