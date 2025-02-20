using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models
{
    public class Cousre_soft
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? grade { get; set; }

        [Required]
        public byte[] ?imgae { get; set; }
        [Required]
        public string? specialization { get; set; }
        [Required]
        public List<Video_soft>? Data { get; set; }
        public int id_instractor { get; set; }
        [ForeignKey("Id")]
        public Instractor_Software ?teacher { get; set; }
        public List<Student>? students { get; set; }
    }
}
