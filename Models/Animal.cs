using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaRodeio.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Nome: ")]
        [StringLength(40, ErrorMessage = "Campo no máximo 40 caracteres")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public string nome { get; set; }

        [Display(Name = "Tipo Animal: ")]
        [Required(ErrorMessage = "campo não pode ser nulo....")]
        public int tipoAnimalid { get; set; }

        [Display(Name = "Tipo Animal: ")]
        [ForeignKey("tipoAnimalid")]
        public virtual TipoAnimal? tipoAnimal { get; set; }

        [Display(Name = "Idade: ")]
        [Range(0, 120, ErrorMessage = "idade entre 0 e 120 anos")]
        public int idade { get; set; }

        [Display(Name = "Peso: ")]
        [Range(0.0, 1000.00, ErrorMessage = "peso entre 0 e 1000 kg")]
        public float peso { get; set; }

        [Display(Name = "Valor: ")]
        [Range(0.0, 10000.00, ErrorMessage = "valor entre 0 e 10000")]
        public float valor { get; set; }
    }
}