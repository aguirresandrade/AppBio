using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Infra.Data.Repositories.Interface;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _repository;
        public AlunoService(IAlunoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
