using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Contracts.Project
{
  public record ProjectUserInfo
  {
    public Guid UserId { get; init; }
    public bool IsActive { get; init; }
    public ProjectUserRoleType Role { get; init; }

    public ProjectUserInfo(
      Guid userId,
      bool isActive,
      ProjectUserRoleType role)
    {
      UserId = userId;
      IsActive = isActive;
      Role = role;
    }
  }
}