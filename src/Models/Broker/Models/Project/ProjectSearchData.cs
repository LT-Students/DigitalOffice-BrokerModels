using System;

namespace DigitalOffice.Models.Broker.Models.Project;

public class ProjectSearchData
{
  public Guid Id { get; }
  public string Name { get; }
  public string ShortName { get; }

  public ProjectSearchData(Guid id, string name, string shortName)
  {
    Id = id;
    Name = name;
    ShortName = shortName;
  }
}
