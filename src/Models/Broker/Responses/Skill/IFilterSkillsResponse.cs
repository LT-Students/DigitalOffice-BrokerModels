using LT.DigitalOffice.Models.Broker.Models.Skill;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Skill;

public interface IFilterSkillsResponse
{
  List<SkillFilteredData> Skills { get; }

  static object CreateObj(List<SkillFilteredData> skills)
  {
    return new
    {
      Skills = skills
    };
  }
}