using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBioBackEnd.Web.API.ViewModels
{
    public class AulaViewModel
    {
        [Key]
        public int IdAula { get; set; }

        [JsonProperty("aula")]
        [Required(ErrorMessage = "Informe o nome do Aluno")]
        [DisplayName("Descrição da Aula")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string DescricaoAula { get; set; }
    }
}
