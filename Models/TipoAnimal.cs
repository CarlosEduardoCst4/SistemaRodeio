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
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "tamanho máximo 100 caracteres")]
        public string descricao { get; set; }

        [Display(Name = "Sigla: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(10, ErrorMessage = "tamanho máximo 10 caracteres")]
        public string sigla { get; set; }
    }
}