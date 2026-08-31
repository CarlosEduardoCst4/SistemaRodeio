using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaRodeio.Models
{
    [Table("Competidor")]
    public class Competidor
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Nome: ")]
        [StringLength(40, ErrorMessage = "Campo no máximo 40 caracteres")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public string nome { get; set; }

        [Display(Name = "Cidade: ")]
        public int cidadeid { get; set; }

        [Display(Name = "Cidade: ")]
        [ForeignKey("cidadeid")]
<<<<<<< HEAD
        public virtual Cidade? cidade { get; set; }
=======
        public virtual Cidade cidade { get; set; }
>>>>>>> 2e2d6fb92510fc9b00fcde228d7eb65df285655c

        [Display(Name = "Idade: ")]
        [Range(0, 120, ErrorMessage = "idade entre 0 e 120 anos")]
        public int idade { get; set; }

        [Display(Name = "Vitorias: ")]
        [Range(0, 1000, ErrorMessage = "vitorias entre 0 e 1000")]
        public int vitorias { get; set; }
    }
}