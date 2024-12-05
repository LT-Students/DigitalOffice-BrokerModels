using System;

namespace DigitalOffice.Models.Broker.Contracts.Department
{
  public record CategoryInfo
  {
    public Guid Id { get; init; }
    public string Name { get; init; }

    public CategoryInfo(
      Guid id,
      string name)
    {
      Id = id;
      Name = name;
    }
  }
}
