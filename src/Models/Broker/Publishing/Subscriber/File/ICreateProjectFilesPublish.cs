using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.File;

public interface ICreateProjectFilesPublish
{
  List<Guid> FilesIds { get; }
  FileAccessType Access { get; }
  Guid ProjectId { get; }

  static object CreateObj(List<Guid> filesIds, FileAccessType access, Guid projectId)
  {
    return new
    {
      FilesIds = filesIds,
      Access = access,
      ProjectId = projectId
    };
  }
}