using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elsewedy_Platform2.Models
{
    public class Cousre_ac
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Required]
        public string ?Description { get; set; }
        [Required]
        public byte[] ?image { get; set; }
        [Required]
        public string ?grade { get; set; }
        [Required]
        public string ?Type { get; set; }
        [Required]
        public List<Video_ac>? videos { get; set; }
        public int id_teacher { get; set; }
        [ForeignKey("Id")]
        public Teacher teacher { get; set; }
        public List<Student> ?students { get; set; }

    }
}
