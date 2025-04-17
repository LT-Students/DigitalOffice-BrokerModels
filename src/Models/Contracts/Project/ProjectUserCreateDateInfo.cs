using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Contracts.Project
{
  public record ProjectUserCreateDateInfo(
    Guid Id,
    Guid UserId,
    Guid ProjectId,
    string ProjectName,
    ProjectUserRoleType Role,
    DateTime CreateAtUtc,
    Guid CreatedBy)
  {
    /// <summary>
    /// Create date identifier.
    /// </summary>
    public Guid Id { get; init; } = Id;

    /// <summary>
    /// User identifier to create.
    /// </summary>
    public Guid UserId { get; init; } = UserId;

    /// <summary>
    /// Project identifier.
    /// </summary>
    public Guid ProjectId { get; init; } = ProjectId;

    /// <summary>
    /// Project name.
    /// </summary>
    public string ProjectName { get; init; } = ProjectName;

    /// <summary>
    /// Project user role.
    /// </summary>
    public ProjectUserRoleType Role { get; init; } = Role;
    
    /// <summary>
    /// Project user's create time.
    /// </summary>
    public DateTime CreateAtUtc { get; init; } = CreateAtUtc;

    /// <summary>
    /// Date creator's Id.
    /// </summary>
    public Guid CreatedBy { get; init; } = CreatedBy;
  }
}