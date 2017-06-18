using System;
using AppBio.Mobile.ViewModel;
using Newtonsoft.Json;

namespace AppBio.Mobile.Models
{
    public class UnidadeAula
    {
        public int IdUnidade { get; set; }

        public int IdAula { get; set; }

        [JsonProperty("data_aula")]
        public DateTime DataAula { get; set; }

        [JsonProperty("dia_semana")]
        public string DiaSemanaAula { get; set; }

        [JsonProperty("hora_aula")]
        public string HoraAula { get; set; }

        public virtual AulaViewModel Aula { get; set; }
        public virtual ViewModel.Unidade Unidade { get; set; }
    }
}
