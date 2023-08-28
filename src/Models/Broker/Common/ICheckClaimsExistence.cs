using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckClaimsExistence
{
  List<Guid> ClaimIds { get; }

  static object CreateObj(List<Guid> claimIds)
  {
    return new
    {
      ClaimIds = claimIds
    };
  }
}
