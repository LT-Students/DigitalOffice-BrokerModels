using DigitalOffice.Models.Broker.Models.Digest;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.File;

public interface ICreateDigestFilesPublish
{
  List<DigestFileData> Files { get; }
  Guid DigestId { get; }

  static object CreateObj(List<DigestFileData> files, Guid digestId)
  {
    return new
    {
      Files = files,
      DigestId = digestId
    };
  }
}