using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Skill
{
  public interface IGetSkillsRequest
  {
    List<Guid> UserIds { get; }

    static object CreateObj(List<Guid> userIds)
    {
      return new
      {
        UserIds = userIds,
      };
    }
  }
}
