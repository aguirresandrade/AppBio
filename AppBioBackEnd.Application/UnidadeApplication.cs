using AppBioBackEnd.Application.Interfaces;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Application
{
    public class UnidadeApplication: ApplicationBase<Unidade>, IUnidadeApplication
    {
        private readonly IUnidadeService _service;

        public UnidadeApplication(IUnidadeService service)
            :base(service)
        {
            _service = service;
        }
    }
}
