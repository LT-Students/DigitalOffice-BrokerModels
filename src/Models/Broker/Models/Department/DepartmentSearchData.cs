using System;

namespace DigitalOffice.Models.Broker.Models.Department;

public class DepartmentSearchData
{
  public Guid Id { get; }
  public string Name { get; }
  public string ShortName { get; }

  public DepartmentSearchData(Guid id, string name, string shortName)
  {
    Id = id;
    Name = name;
    ShortName = shortName;
  }
}
