using System;

namespace DigitalOffice.Models.Broker.Models.Project;

public class ProjectSearchData
{
  /// <summary>
  /// Unique project identifier.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// Project name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Project short name.
  /// </summary>
  public string ShortName { get; }

  public ProjectSearchData(Guid id, string name, string shortName)
  {
    Id = id;
    Name = name;
    ShortName = shortName;
  }
}
