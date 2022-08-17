using LT.DigitalOffice.Models.Broker.Models.Skill;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Skill
{
    public interface IGetUserSkillsResponse
    {
        List<UserSkillData> Skills { get; }

        static object CreateObj(List<UserSkillData> skills)
        {
            return new
            {
                Skills = skills,
            };
        }
    }
}
