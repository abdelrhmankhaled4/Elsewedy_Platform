using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int National_Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Required]
        public string ?grade { get;  set; }
        public List<Cousre_ac> cousres_ac { get; set; }
        public List<Cousre_soft> cousre_soft { get; set; }
    }
}
