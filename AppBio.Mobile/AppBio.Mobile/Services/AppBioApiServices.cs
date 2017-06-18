using System.Collections.Generic;
using System.Threading.Tasks;
using AppBio.Mobile.Models;
using AppBio.Mobile.Services.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppBio.Mobile.Services.AppBioApiServices))]
namespace AppBio.Mobile.Services
{
    public class AppBioApiServices: IAppBioApiServices
    {
        public async Task<List<UnidadeAula>> GetUnidadeAulaAsync(int idUnidade, int idAula, int idAluno)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Unidade>> GetUnidadeAsync(int idUnidade)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Aula>> GetAulaAsync(int idAula)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Aluno>> GetAlunoAsync(int idAluno)
        {
            throw new System.NotImplementedException();
        }
    }
}
