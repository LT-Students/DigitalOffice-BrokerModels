namespace DigitalOffice.Models.Contracts.User
{
  /// <summary>
  /// Communication information.
  /// </summary>
  public record UserCommunicationInfo(
    CommunicationType Type,
    string Value)
  {
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
