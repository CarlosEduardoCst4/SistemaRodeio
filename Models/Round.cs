using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaRodeio.Models
{
    [Table("Round")]
    public class Round
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Competidor: ")]
        public int competidorid { get; set; }
        [ForeignKey("competidorid")]
        public virtual Competidor? competidor { get; set; }

        [Display(Name = "Animal: ")]
        public int animalid { get; set; }
        [ForeignKey("animalid")]
        public virtual Animal? animal { get; set; }

        [Display(Name = "Data: ")]
        public DateTime data { get; set; }

        [Display(Name = "Nota do Animal: ")]
        public float notAnimal { get; set; }

        [Display(Name = "Nota do Competidor: ")]
        public float notCompetidor { get; set; }

        [Display(Name = "Penalidade: ")]
        public float penalidade { get; set; }
    }
}