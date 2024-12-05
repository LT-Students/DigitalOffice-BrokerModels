using System.Text.Json.Serialization;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ProjectUserRoleType>))]
public enum ProjectUserRoleType
{
  Manager,
  Employee,
  Observer = 100
}
