using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBioBackEnd.Web.API.ViewModels
{
    public class AlunoViewModel
    {
        [Key]
        public int IdAluno { get; set; }

        [JsonProperty("nome_aluno")]
        [Required(ErrorMessage ="Informe o nome do Aluno")]
        [DisplayName("Nome do Aluno")]
        [MaxLength(100, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeAluno { get; set; }

        [JsonProperty("email")]
        [DisplayName("E-mail do Aluno")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string EmailAluno { get; set; }

        [JsonProperty("perfil_facebook")]
        [DisplayName("Perfil do Facebook")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string PerfilFacebook { get; set; }

        [JsonProperty("data_nascimento")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
