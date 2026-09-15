using System.Text.Json.Serialization;

namespace ClinicaVeterinaria.Models
{
    public class Consulta 
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Motivo { get; set; }
        public int PetId { get; set; }
        public int VeterinarioId { get; set; }

        [JsonIgnore]
        public Consulta? consulta { get; set; }
    }


}
