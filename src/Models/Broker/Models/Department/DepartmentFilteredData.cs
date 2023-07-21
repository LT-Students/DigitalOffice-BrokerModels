using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Department;

public class DepartmentFilteredData
{
  public Guid Id { get; }
  public string Name { get; }
  public List<Guid> UsersIds { get; }

  public DepartmentFilteredData(Guid id, string name, List<Guid> usersIds)
  {
    Id = id;
    Name = name;
    UsersIds = usersIds;
  }
}
