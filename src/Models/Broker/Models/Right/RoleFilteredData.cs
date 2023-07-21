using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Right;

public class RoleFilteredData
{
  public Guid Id { get; }
  public string Name { get; }
  public List<Guid> UsersIds { get; }

  public RoleFilteredData(Guid id, string name, List<Guid> usersIds)
  {
    Id = id;
    Name = name;
    UsersIds = usersIds;
  }
}
