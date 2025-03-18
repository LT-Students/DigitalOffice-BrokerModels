using System;

namespace DigitalOffice.Models.Contracts.User
{
  public record UserRemoveDateInfo(
    Guid UserRemoveDateId,
    DateTime RemoveAtUtc)
  {
    /// <summary>
    /// ID.
    /// </summary>
    public Guid UserRemoveDateId { get; init; } = UserRemoveDateId;
    
    /// <summary>
    /// User's remove time.
    /// </summary>
    public DateTime RemoveAtUtc { get; init; } = RemoveAtUtc;
  }
}