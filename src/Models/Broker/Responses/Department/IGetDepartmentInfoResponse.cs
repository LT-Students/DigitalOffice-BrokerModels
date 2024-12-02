using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Department
{
  public interface IGetDepartmentInfoResponse
  {
    Guid Id { get; }

    string Name { get; }

    string ShortName { get; }

    List<Guid> UsersIds { get; }

    public static object CreateObj(
      Guid id,
      string name,
      string shortName,
      List<Guid> usersIds)
    {
      return new { Id = id, Name = name, ShortName = shortName, UsersIds = usersIds };
    }
  }
}