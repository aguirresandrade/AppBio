using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBioBackEnd.Web.API.ViewModels
{
    public class UnidadeAula
    {
        [Key]
        public int IdUnidade { get; set; }

        [Key]
        public int IdAula { get; set; }

        [JsonProperty("data_aula")]
        [DisplayName("Data da Aula")]
        [Required(ErrorMessage = "Informe a data da aula")]
        public DateTime DataAula { get; set; }

        [JsonProperty("dia_semana")]
        [DisplayName("Dia da Semana")]
        [Required(ErrorMessage = "Informe o dia da semana da aula")]
        public string DiaSemanaAula { get; set; }

        [JsonProperty("hora_aula")]
        [DisplayName("Hora da Aula")]
        [Required(ErrorMessage = "Informe a hora da aula")]
        public string HoraAula { get; set; }

        public virtual AulaViewModel Aula { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}
