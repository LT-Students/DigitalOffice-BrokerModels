using System.Text.Json.Serialization;

namespace DigitalOffice.Models.Contracts.User
{
  /// <summary>
  /// Communication type.
  /// </summary>
  [JsonConverter(typeof(JsonStringEnumConverter<CommunicationType>))]
  public enum CommunicationType
  {
    Email,
    Telegram,
    Phone,
    Skype,
    Twitter,
    BaseEmail
  }
}
