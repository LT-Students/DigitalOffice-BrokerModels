using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum LeaveType
{
  Vacation = 0,
  SickLeave = 1,
  Training = 2,
  Idle = 3,
  Prolonged = 4,
  Decree = 5
}
