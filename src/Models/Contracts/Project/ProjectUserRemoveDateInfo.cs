using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Contracts.Project
{
  public record ProjectUserRemoveDateInfo(
    Guid Id,
    Guid UserId,
    Guid ProjectId,
    string ProjectName,
    DateTime RemoveAtUtc,
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
    /// Project user's remove time.
    /// </summary>
    public DateTime RemoveAtUtc { get; init; } = RemoveAtUtc;

    /// <summary>
    /// Date creator's Id.
    /// </summary>
    public Guid CreatedBy { get; init; } = CreatedBy;
  }
}