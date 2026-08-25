using System.ComponentModel.DataAnnotations;
namespace SistemaRodeio.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string nome { get; set; }
        public TipoAnimal tipoAnimal { get; set; }
        public int idade { get; set; }
        public float peso { get; set; }
        public float valor { get; set; }
    }
}