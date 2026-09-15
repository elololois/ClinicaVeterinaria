using System.Text.Json.Serialization;

namespace ClinicaVeterinaria.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string Especialidade { get; set; }

        [JsonIgnore]
        public Veterinario? veterinario { get; set; }

    }


}
