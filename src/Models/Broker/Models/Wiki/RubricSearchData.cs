using System;

namespace DigitalOffice.Models.Broker.Models.Wiki;

public class RubricSearchData
{
  /// <summary>
  /// Rubric Unique identifier.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// Rubric name.
  /// </summary>
  public string Name { get; }

  public RubricSearchData(Guid id, string name)
  {
    Id = id;
    Name = name;
  }
}
