using Newtonsoft.Json;

namespace AppBio.Mobile.Models
{
    public class Unidade
    {
        public int IdUnidade { get; set; }

        [JsonProperty("nome_unidade")]
        public string NomeUnidade { get; set; }
    }
}
