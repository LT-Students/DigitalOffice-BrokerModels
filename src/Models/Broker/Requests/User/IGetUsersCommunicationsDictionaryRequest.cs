using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.User;

public interface IGetUsersCommunicationsDictionaryRequest
{
  List<Guid> UsersIds { get; }

  static object CreateObj(List<Guid> usersIds)
  {
    return new
    {
      UsersIds = usersIds
    };
  }
}
