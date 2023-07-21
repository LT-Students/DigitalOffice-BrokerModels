using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Project;

public class ProjectData
{
  public Guid Id { get; }
  public string Name { get; }
  public string Status { get; }
  public string ShortName { get; }
  public string ShortDescription { get; }
  public ProjectDepartmentData Department { get; }
  public List<ProjectUserData> Users { get; }

  public ProjectData(
    Guid id,
    string name,
    string status,
    string shortName,
    string shortDescription,
    ProjectDepartmentData department,
    List<ProjectUserData> users)
  {

    Id = id;
    Name = name;
    Status = status;
    ShortName = shortName;
    ShortDescription = shortDescription;
    Department = department;
    Users = users;
  }
}
