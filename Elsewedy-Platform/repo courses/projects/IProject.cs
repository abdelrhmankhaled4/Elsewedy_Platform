using Elsewedy_Platform.Models.DTO;

namespace Elsewedy_Platform.repo_courses.projects
{
    public interface IProject
    {
        public bool Add_Project(Project_Infromation_DTO x);
        public List<Project_Infromation_DTO> Get_All();

    }
}
