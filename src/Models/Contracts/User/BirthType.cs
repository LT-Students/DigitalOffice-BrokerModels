using System.Text.Json.Serialization;

namespace DigitalOffice.Models.Contracts.User;

/// <summary>
/// Birthdate display option.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<BirthType>))]
public enum BirthType
{
  /// <summary>
  /// Don't show.
  /// </summary>
  Closed = 0,

  /// <summary>
  /// Show.
  /// </summary>
  Open = 1,

  /// <summary>
  /// Show only day and month.
  /// </summary>
  WithoutYear = 2,
}
