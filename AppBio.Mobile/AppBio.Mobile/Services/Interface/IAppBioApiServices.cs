using System.Collections.Generic;
using System.Threading.Tasks;
using AppBio.Mobile.Models;

namespace AppBio.Mobile.Services.Interface
{
    public interface IAppBioApiServices
    {
        Task<List<UnidadeAula>> GetUnidadeAulaAsync(int idUnidade, int idAula, int idAluno);

        Task<List<Unidade>> GetUnidadeAsync(int idUnidade);
        
        Task<List<Aula>> GetAulaAsync(int idAula);

        Task<List<Aluno>> GetAlunoAsync(int idAluno);
    }
}
