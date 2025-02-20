using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Required]
        public string ?password { get; set; }
        [Required]
        public string ?subject { get; set; }
        [Required]
        public List<Cousre_ac> ?cousre { get; set; }
    }
}
