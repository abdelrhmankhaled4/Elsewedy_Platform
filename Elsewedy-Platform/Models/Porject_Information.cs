using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform.Models
{
    public class Porject_Information
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string ?company_name { get; set; }
        [Required]
        public string ?phone { get; set; }
        [Required]
        public string ?f_name { get; set; }
        [Required]
        public string ?l_name { get; set; }
        [Required]
        [EmailAddress]
        public string ?email { get; set; }
        [Required]
        public string ?project_information { get; set; }
        public string ?massege {  get; set; }
    }
}
