using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Message;

public interface ICreateWorkspaceRequest
{
  string Name { get; }
  Guid CreaterId { get; }
  List<Guid> UsersIds { get; }

  static object CreateObj(string name, Guid createrId, List<Guid> usersIds)
  {
    return new
    {
      Name = name,
      CreaterId = createrId,
      UsersIds = usersIds
    };
  }
}
