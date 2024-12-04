using System.Text.Json.Serialization;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<DepartmentUserRole>))]
public enum DepartmentUserRole
{
  Employee,
  Manager
}
