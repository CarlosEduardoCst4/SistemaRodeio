using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaRodeio.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Descrição: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(40, ErrorMessage = "tamanho máximo 40 caracteres")]
        public string descricao { get; set; }
    }
}