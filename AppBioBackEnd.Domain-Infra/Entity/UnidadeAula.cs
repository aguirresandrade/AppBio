using System;

namespace AppBioBackEnd.Domain.Entity
{
    public class UnidadeAula
    {
        public int IdUnidade { get; set; }
        public int IdAula { get; set; }
        public DateTime DataAula { get; set; }
        public string DiaSemanaAula { get; set; }
        public string HoraAula { get; set; }

        public virtual Aula Aula { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}
