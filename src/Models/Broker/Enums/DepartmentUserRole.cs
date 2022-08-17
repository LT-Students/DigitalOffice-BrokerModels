using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LT.DigitalOffice.Models.Broker.Enums
{
  [JsonConverter(typeof(StringEnumConverter))]
  public enum DepartmentUserRole
  {
    Employee,
    Manager
  }
}
