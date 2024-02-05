using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterUserSkillsRequest
  {
    List<Guid> SkillIds { get; }

    static object CreateObj(List<Guid> skillIds)
    {
      return new 
      {
        SkillIds = skillIds
      };
    }
  }
}
