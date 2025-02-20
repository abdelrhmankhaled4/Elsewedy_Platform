using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elsewedy_Platform2.Models
{
    public class Video_ac
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] ?Data { get; set; }
        public Cousre_ac ?Cousre_ac { get; set; }
    }
}
