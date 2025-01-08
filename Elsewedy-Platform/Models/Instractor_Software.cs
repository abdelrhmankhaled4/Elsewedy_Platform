using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models
{
    public class Instractor_Software
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? password { get; set; }
        [Required]
        public string? specialization { get; set; }
        public List<Cousre_soft> cousre_s {  get; set; }

    }
}
