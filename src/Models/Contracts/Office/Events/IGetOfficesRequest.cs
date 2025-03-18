using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Office.Events
{
  public interface IGetOfficesRequest
  {
    public List<Guid> OfficeIds { get; set; }
    
    public List<Guid> UserIds { get; set; }
    
    static object CreateObj(
      List<Guid> officeIds,
      List<Guid> userIds)
    {
      return new
      {
        OfficeIds = officeIds,
        UserIds = userIds
      };
    }
  }
}