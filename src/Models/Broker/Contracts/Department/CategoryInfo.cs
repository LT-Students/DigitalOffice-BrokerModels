using System;

namespace DigitalOffice.Models.Broker.Contracts.Department
{
  public class CategoryInfo
  {
    public Guid Id { get; }
    public string Name { get; }

    public CategoryInfo(
      Guid id,
      string name)
    {
      Id = id;
      Name = name;
    }
  }
}
