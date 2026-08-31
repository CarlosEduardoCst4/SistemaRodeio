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
        [StringLength(40, ErrorMessage = "Campo no máximo 40 caracteres")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public string descricao { get; set; }

        [Display(Name = "Sigla: ")]
        [StringLength(2, ErrorMessage = "Campo no máximo 2 caracteres")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public string sigla { get; set; }
    }
}