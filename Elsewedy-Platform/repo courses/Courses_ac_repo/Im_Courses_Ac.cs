using Elsewedy_Platform2.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;

namespace Elsewedy_Platform2.repo_courses
{
    public class Im_Courses_Ac : ICourses_Ac
    {
        private readonly AppDbContext context;
        public Im_Courses_Ac(AppDbContext context)
        {
            this.context = context;
        }
        public List<Display_on_home> GetCourses()
        {
            var list =  context.cousre_As.Select(c => new Display_on_home
            {
                grade = c.grade,
                Name = c.Name,
                Type = c.Type,
                imgae = c.image
            }).ToList();
            return list;
        }
    }
}
