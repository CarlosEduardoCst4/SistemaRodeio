using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaRodeio.Models
{
    [Table("TipoAnimal")]
    public class TipoAnimal
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Descrição: ")]
        [StringLength(100, ErrorMessage = "Campo no máximo 100 caracteres")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public string descricao { get; set; }
    }
}