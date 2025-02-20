using Elsewedy_Platform.Models;
using Elsewedy_Platform.Models.DTO;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;

namespace Elsewedy_Platform.repo_courses.projects
{
    public class Im_Project_Information : IProject
    {
        private readonly AppDbContext context;
        public Im_Project_Information(AppDbContext context)
        {
            this.context = context;
        }
        public bool Add_Project(Project_Infromation_DTO x)
        {
            try
            {
                var project = new Porject_Information
                {
                    f_name = x.f_name,
                    company_name = x.company_name,
                    email = x.email,
                    l_name = x.l_name,
                    massege = x.massege,
                    phone = x.phone,
                    project_information = x.project_information,
                };
                context.porject_Information.Add(project);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Project_Infromation_DTO> Get_All()
        {
            var list = context.porject_Information.Select(x=>new Project_Infromation_DTO
            {
                f_name = x.f_name,
                company_name = x.company_name,
                email = x.email,
                l_name = x.l_name,
                massege = x.massege,
                phone = x.phone,
                project_information = x.project_information,
            }).ToList();
            return list;
        }
    }
}
