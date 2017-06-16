using AppBioBackEnd.Application.Interfaces;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Application
{
    public class AlunoApplication: ApplicationBase<Aluno>, IAlunoApplication
    {
        private readonly IAlunoService _service;

        public AlunoApplication(IAlunoService service)
            :base(service)
        {
            _service = service;
        }
    }
}
