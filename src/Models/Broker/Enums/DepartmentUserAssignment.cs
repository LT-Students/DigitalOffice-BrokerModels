using System.Text.Json.Serialization;

namespace DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<DepartmentUserAssignment>))]
public enum DepartmentUserAssignment
{
  Employee = 0,
  Director = 10
}
