using LT.DigitalOffice.Models.Broker.Models.Project;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Project;

public interface IGetProjectsResponse
{
  List<ProjectData> Projects { get; }

  static object CreateObj(
    List<ProjectData> projects)
  {
    return new
    {
      Projects = projects
    };
  }
}
