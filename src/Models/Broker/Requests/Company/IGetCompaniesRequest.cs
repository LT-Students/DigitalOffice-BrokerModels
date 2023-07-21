using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Company;

public interface IGetCompaniesRequest
{
  List<Guid> UsersIds { get; }
  bool? UserIsActive { get; }

  static object CreateObj(
    List<Guid> usersIds = null,
    bool? userIsActive = true)
  {
    return new
    {
      UsersIds = usersIds,
      UserIsActive = userIsActive
    };
  }
}
