using System;

namespace DigitalOffice.Models.Broker.Models.Department;

public class DepartmentSearchData
{
  /// <summary>
  /// Unique department identifier.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// Department name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Department short name.
  /// </summary>
  public string ShortName { get; }

  public DepartmentSearchData(Guid id, string name, string shortName)
  {
    Id = id;
    Name = name;
    ShortName = shortName;
  }
}
