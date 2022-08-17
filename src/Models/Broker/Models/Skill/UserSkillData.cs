using System;

namespace LT.DigitalOffice.Models.Broker.Models.Skill
{
    public class UserSkillData
    {
        public Guid Id { get; }
        public string Name { get; }

        public UserSkillData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
