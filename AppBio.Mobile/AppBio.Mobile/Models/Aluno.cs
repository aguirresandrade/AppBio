using System;
using AppBio.Mobile.ViewModel;
using Newtonsoft.Json;

namespace AppBio.Mobile.Models
{
    public class Aluno: BaseViewModel
    {
        public int IdAluno { get; set; }

        [JsonProperty("nome_aluno")]
        public string NomeAluno { get; set; }

        [JsonProperty("email")]
        public string EmailAluno { get; set; }

        [JsonProperty("perfil_facebook")]
        public string PerfilFacebook { get; set; }

        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }
    }

    class AlunoImpl : Aluno
    {
    }
}
