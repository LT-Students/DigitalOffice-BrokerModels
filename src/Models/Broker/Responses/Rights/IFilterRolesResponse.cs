using LT.DigitalOffice.Models.Broker.Models.Right;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Rights;

public interface IFilterRolesResponse
{
  List<RoleFilteredData> Roles { get; }

  static object CreateObj(List<RoleFilteredData> roles)
  {
    return new
    {
      Roles = roles
    };
  }
}
