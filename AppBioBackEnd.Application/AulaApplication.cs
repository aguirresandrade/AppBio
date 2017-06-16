using AppBioBackEnd.Application.Interfaces;
using AppBioBackEnd.Domain.Entity;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Application
{
    public class AulaApplication: ApplicationBase<Aula>, IAulaApplication
    {
        private readonly IAulaService _service;

        public AulaApplication(IAulaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
