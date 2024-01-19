using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.File
{
  public interface ICreateFilesRequest
  {
    List<Guid> FilesIds { get; }
    Guid EntityId { get; }

    static object CreateObj(List<Guid> filesIds, Guid entityId)
    {
      return new
      {
        FilesIds = filesIds,
        EntityId = entityId
      };
    }
  }
}
