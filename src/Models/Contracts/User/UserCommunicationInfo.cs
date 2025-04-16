using System;

namespace DigitalOffice.Models.Contracts.User
{
  /// <summary>
  /// Communication information.
  /// </summary>
  public record UserCommunicationInfo(
    Guid Id,
    CommunicationType Type,
    string Value)
  {
    /// <summary>
    /// Communication Id.
    /// </summary>
    public Guid Id { get; init; } = Id;
    
    /// <summary>
    /// Communication type.
    /// </summary>
    public CommunicationType Type { get; init; } = Type;

    /// <summary>
    /// Communication value.
    /// </summary>
    public string Value { get; init; } = Value;
  }
}
