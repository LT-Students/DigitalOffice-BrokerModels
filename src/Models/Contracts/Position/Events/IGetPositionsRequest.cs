using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Position.Events
{
  public interface IGetPositionsRequest
  {
    public List<Guid> PositionIds { get; set; }
    
    public List<Guid> UserIds { get; set; }
    
    static object CreateObj(
      List<Guid> positionIds,
      List<Guid> userIds)
    {
      return new
      {
        PositionIds = positionIds,
        UserIds = userIds
      };
    }
  }
}