using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LT.DigitalOffice.Models.Broker.Enums
{
  [JsonConverter(typeof(StringEnumConverter))]
  public enum FileAccessType
  {
    Manager,
    Team,
    Public
  }
}
