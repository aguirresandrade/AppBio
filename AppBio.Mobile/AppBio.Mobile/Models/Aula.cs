using Newtonsoft.Json;

namespace AppBio.Mobile.Models
{
    public class Aula
    {
        public int IdAula { get; set; }

        [JsonProperty("aula")]
        public string DescricaoAula { get; set; }
    }
}
