using AppBioBackEnd.Application.Interfaces;
using AppBioBackEnd.Services.Interfaces;

namespace AppBioBackEnd.Application
{
    public class ApplicationBase<TEntity>: IApplicationBase<TEntity> where TEntity:class
    {
        private readonly IServiceBase<TEntity> _service;

        public ApplicationBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }
    }
}
