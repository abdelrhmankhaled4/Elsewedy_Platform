using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform.Models.DTO
{
    public class Project_Infromation_DTO
    {
        [Required]
        public string? company_name { get; set; }
        [Required]
        public string? phone { get; set; }
        [Required]
        public string? f_name { get; set; }
        [Required]
        public string? l_name { get; set; }
        [Required]
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        public string? project_information { get; set; }
        public string? massege { get; set; }
    }
}
