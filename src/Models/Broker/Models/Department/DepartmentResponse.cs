using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Models.Department
{
  public class DepartmentResponse
  {
    public Guid Id { get; }
    public string Name { get; }
    public string ShortName { get; }
    public List<Guid> UsersIds { get; }

    public DepartmentResponse(
      Guid id,
      string name,
      string shortName,
      List<Guid> usersIds = null)
    {
      Id = id;
      Name = name;
      ShortName = shortName;
      UsersIds = usersIds;
    }
  }
}