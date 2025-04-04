using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IGetProjectsResponse
  {
    List<ProjectInfo> Projects { get; }

    static object CreateObj(List<ProjectInfo> projects)
    {
      return new
      {
        Projects = projects
      };
    }
  }
}