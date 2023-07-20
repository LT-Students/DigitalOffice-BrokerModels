using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.User;

public interface IGetUsersDataRequest
{
  List<Guid> UsersIds { get; }

  bool IncludeBaseEmail { get; }

  static object CreateObj(
    List<Guid> usersIds,
    bool includeBaseEmail = false)
  {
    return new
    {
      UsersIds = usersIds,
      IncludeBaseEmail = includeBaseEmail
    };
  }
}
