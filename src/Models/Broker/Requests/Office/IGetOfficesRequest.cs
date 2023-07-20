using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Office;

public interface IGetOfficesRequest
{
  List<Guid> UserIds { get; }

  static object CreateObj(List<Guid> usersIds)
  {
    return new
    {
      UserIds = usersIds
    };
  }
}
