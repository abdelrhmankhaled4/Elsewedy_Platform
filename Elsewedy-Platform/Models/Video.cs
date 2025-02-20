using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elsewedy_Platform2.Models
{
    public class Video_soft
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[]? Data { get; set; }
        
        public Cousre_soft? Cousre_soft { get; set; }

    }
}
