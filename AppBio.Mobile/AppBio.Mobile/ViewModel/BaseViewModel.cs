using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AppBio.Mobile.Annotations;

namespace AppBio.Mobile.ViewModel
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Método genérico de Navegação que é implementado em uma ViewModel Genérica.
        /// Este método é assincrono
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task PushAsync<TViewModel>(params IEditableObject[] args) where TViewModel: BaseViewModel
        {
            
        }
    }
}
