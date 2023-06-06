using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Skill
{
  public class SkillFilteredData
  {
    public Guid Id { get; }
    public string Name { get; }
    public List<Guid> UsersIds { get; }

    public SkillFilteredData(Guid id, string name, List<Guid> usersIds)
    {
      Id = id;
      Name = name;
      UsersIds = usersIds;
    }
  }
}