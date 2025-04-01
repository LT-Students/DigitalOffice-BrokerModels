using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Contracts.Department
{
  public record DepartmentUserCreateDateInfo(
    Guid Id,
    Guid UserId,
    Guid DepartmentId,
    DepartmentUserRole Role,
    DepartmentUserAssignment Assignment,
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
    /// Department identifier.
    /// </summary>
    public Guid DepartmentId { get; init; } = DepartmentId;

    /// <summary>
    /// Department user role.
    /// </summary>
    public DepartmentUserRole Role { get; init; } = Role;

    /// <summary>
    /// Department user assignment.
    /// </summary>
    public DepartmentUserAssignment Assignment { get; init; } = Assignment;
    
    /// <summary>
    /// Department user's create time.
    /// </summary>
    public DateTime CreateAtUtc { get; init; } = CreateAtUtc;

    /// <summary>
    /// Date creator's Id.
    /// </summary>
    public Guid CreatedBy { get; init; } = CreatedBy;
  }
}