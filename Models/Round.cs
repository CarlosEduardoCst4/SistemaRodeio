using System.ComponentModel.DataAnnotations;
namespace SistemaRodeio.Models
{
    public class Round
    {
        public int id { get; set; }
        public Competidor competidor { get; set; }
        public Animal animal { get; set; }
        public DateTime data { get; set; }
        public float notAnimal { get; set; }
        public float notCompetidor { get; set; }
        public float penalidade { get; set; }
    }
}