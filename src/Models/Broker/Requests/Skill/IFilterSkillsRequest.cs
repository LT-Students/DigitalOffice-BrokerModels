using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Skill;

public interface IFilterSkillsRequest
{
  List<Guid> SkillsIds { get; }

  static object CreateObj(List<Guid> skillsIds)
  {
    return new
    {
      SkillsIds = skillsIds,
    };
  }
}