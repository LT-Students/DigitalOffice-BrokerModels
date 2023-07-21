using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Project;

public interface ICheckProjectFilesAccessesRequest
{
  Guid UserId { get; }
  List<Guid> FilesIds { get; }

  static object CreateObj(Guid userId, List<Guid> filesIds)
  {
    return new
    {
      UserId = userId,
      FilesIds = filesIds
    };
  }
}
