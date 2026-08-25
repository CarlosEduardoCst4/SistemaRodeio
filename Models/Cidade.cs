using System.ComponentModel.DataAnnotations;
namespace SistemaRodeio.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public char sigla { get; set; }
    }
}