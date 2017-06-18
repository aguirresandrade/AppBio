using AppBio.Mobile.Services.Interface;
using Xamarin.Forms;

namespace AppBio.Mobile.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        private readonly IAppBioApiServices _appbioservices;
        public MainViewModel(IAppBioApiServices appbioservices)
        {
            _appbioservices = appbioservices;

            ExecutaAluno = new Command(ExecutaAlunoCommand);
        }

        public Command ExecutaAluno;
        public Command ExecutaUnidade;
        public Command ExecutaAula;
        public Command ExecutaUnidadeAula;

        public async void ExecutaAlunoCommand()
        {
            await 
        }
    }
}
