using LT.DigitalOffice.Models.Broker.Models.Right;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Rights;

public interface IGetUserRolesResponse
{
  List<RoleData> Roles { get; }

  static object CreateObj(List<RoleData> roles)
  {
    return new
    {
      Roles = roles
    };
  }
}
