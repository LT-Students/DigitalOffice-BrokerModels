using System;

namespace LT.DigitalOffice.Models.Broker.Models.Project;

public class ProjectDepartmentData
{
  public Guid ProjectId { get; }
  public Guid DepartmentId { get; }

  public ProjectDepartmentData(Guid projectId, Guid departmentId)
  {
    ProjectId = projectId;
    DepartmentId = departmentId;
  }
}
