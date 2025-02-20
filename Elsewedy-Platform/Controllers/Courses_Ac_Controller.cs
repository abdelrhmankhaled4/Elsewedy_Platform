using Elsewedy_Platform2.repo_courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elsewedy_Platform2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Courses_Ac_Controller : ControllerBase
    {
        private readonly ICourses_Ac context;
        public Courses_Ac_Controller(ICourses_Ac context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var x= context.GetCourses(); 
            return Ok(x);
        }
    }
}
