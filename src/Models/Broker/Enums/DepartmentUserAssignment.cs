using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum DepartmentUserAssignment
{
  Employee = 0,
  Director = 10
}
