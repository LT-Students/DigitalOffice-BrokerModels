using System.Text.Json.Serialization;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ProjectStatusType>))]
public enum ProjectStatusType
{
  Active,
  Closed,
  Suspend,
  Archived,
  DoesNotExist = 100
}
