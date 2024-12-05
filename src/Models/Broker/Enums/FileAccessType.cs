using System.Text.Json.Serialization;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<FileAccessType>))]
public enum FileAccessType
{
  Manager,
  Team,
  Public
}
