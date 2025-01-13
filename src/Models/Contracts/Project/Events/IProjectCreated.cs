using System;

namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IProjectCreated
  {
    ProjectInfo Project { get; }
    Guid CreatorId { get; }

    static object CreateObj(
      ProjectInfo project,
      Guid creatorId)
    {
      return new
      {
        Project = project,
        CreatorId = creatorId
      };
    }
  }
}