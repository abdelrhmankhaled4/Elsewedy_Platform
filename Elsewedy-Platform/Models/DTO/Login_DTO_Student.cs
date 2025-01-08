using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models.DTO
{
    public class Login_DTO_Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int National_Id { get; set; }
    }
}
