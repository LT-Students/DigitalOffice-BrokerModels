using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DigitalOffice.Models.Contracts.Vacation
{
  [JsonConverter(typeof(StringEnumConverter))]
  public enum VacationType
  {
    Planned,
    Actual,
    SickLeave,
    Training,
    Idle,
    Prolonged,
    Decree
  }
}
