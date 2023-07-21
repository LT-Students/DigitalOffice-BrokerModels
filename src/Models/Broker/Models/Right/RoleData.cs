using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Right;

public class RoleData
{
  public Guid Id { get; }
  public string Name { get; }
  public List<int> RightsIds { get; }
  public List<Guid> UsersIds { get; }

  public RoleData(
      Guid id,
      string name,
      List<int> rightsIds,
      List<Guid> usersIds)
  {
    Id = id;
    Name = name;
    RightsIds = rightsIds;
    UsersIds = usersIds;
  }
}
