using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Models.Project;

public class ProjectUserData
{
  public Guid UserId { get; }
  public Guid ProjectId { get; }
  public bool IsActive { get; }
  public ProjectUserRoleType ProjectUserRole { get; }

  public ProjectUserData(Guid userId, Guid projectId, bool isActive, ProjectUserRoleType projectUserRole)
  {
    UserId = userId;
    ProjectId = projectId;
    IsActive = isActive;
    ProjectUserRole = projectUserRole;
  }
}
