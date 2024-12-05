using System.Text.Json.Serialization;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ContractTerm>))]
public enum ContractTerm
{
  FixedTerm,
  Perpetual
}
