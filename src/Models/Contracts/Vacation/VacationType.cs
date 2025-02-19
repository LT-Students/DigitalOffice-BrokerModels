using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DigitalOffice.Models.Contracts.Vacation
{
  [JsonConverter(typeof(StringEnumConverter))]
  public enum VacationType
  {
    Planned = 0,
    Actual = 1,
    SickLeave = 2,
    Training = 3,
    Idle = 4,
    Prolonged = 5,
    Decree = 6
  }
}
