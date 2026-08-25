using System.ComponentModel.DataAnnotations;
namespace SistemaRodeio.Models
{
    public class Competidor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Cidade cidade { get; set; }
        public int idade { get; set; }
        public int vitorias { get; set; }
    }
}