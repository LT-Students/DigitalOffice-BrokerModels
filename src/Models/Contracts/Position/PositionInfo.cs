using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Position
{
  public record PositionInfo
  {
    public Guid Id { get; }
    public string Name { get; }
    public List<Guid> UserIds { get; }

    public PositionInfo(
      Guid id,
      string name,
      List<Guid> userIds)
    {
      Id = id;
      Name = name;
      UserIds = userIds;
    }
  }
}