using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckCompaniesExistence
{
  public List<Guid> CompanyIds { get; set; }

  static object CreateObj(List<Guid> companyIds)
  {
    return new
    {
      CompanyIds = companyIds
    };
  }
}