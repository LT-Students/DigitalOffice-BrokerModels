using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Position;

public class PositionData
{
  public Guid Id { get; }
  public string Name { get; }
  public List<Guid> UsersIds { get; }

  public PositionData(Guid id, string name, List<Guid> usersIds)
  {
    Id = id;
    Name = name;
    UsersIds = usersIds;
  }
}
