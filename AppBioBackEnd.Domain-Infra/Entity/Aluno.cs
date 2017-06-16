using System;

namespace AppBioBackEnd.Domain.Entity
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public string EmailAluno { get; set; }
        public string PerfilFacebook { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
