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
<<<<<<< HEAD
        public virtual Competidor? competidor { get; set; }
=======
        public virtual Competidor competidor { get; set; }
>>>>>>> 2e2d6fb92510fc9b00fcde228d7eb65df285655c

        [Display(Name = "Animal: ")]
        public int animalid { get; set; }
        [ForeignKey("animalid")]
<<<<<<< HEAD
        public virtual Animal? animal { get; set; }
=======
        public virtual Animal animal { get; set; }
>>>>>>> 2e2d6fb92510fc9b00fcde228d7eb65df285655c

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