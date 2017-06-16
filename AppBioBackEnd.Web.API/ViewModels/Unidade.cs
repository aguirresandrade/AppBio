using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBioBackEnd.Web.API.ViewModels
{
    public class Unidade
    {
        [Key]
        public int IdUnidade { get; set; }

        [JsonProperty("nome_unidade")]
        [DisplayName("Nome da Unidade")]
        [Required(ErrorMessage = "Informe o Nome da Unidade")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeUnidade { get; set; }
    }
}
