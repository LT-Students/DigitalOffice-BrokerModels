using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.File;

public interface ICreateClaimFilesPublish
{
  List<Guid> FilesIds { get; }
  Guid ClaimId { get; }

  static object CreateObj(List<Guid> filesIds, Guid claimId)
  {
    return new
    {
      FilesIds = filesIds,
      ClaimId = claimId
    };
  }
}
