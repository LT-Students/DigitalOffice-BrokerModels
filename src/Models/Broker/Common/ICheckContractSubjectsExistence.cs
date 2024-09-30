using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckContractSubjectsExistence
{
  public List<Guid> ContractSubjectIds { get; set; }

  static object CreateObj(List<Guid> contractSubjectIds)
  {
    return new
    {
      ContractSubjectId = contractSubjectIds
    };
  }
}
