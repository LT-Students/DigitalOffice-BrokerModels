using System;

namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IProjectUpdated
  {
    ProjectInfo Project { get; }
    Guid ModifierId { get; }

    static object CreateObj(
      ProjectInfo project,
      Guid modifierId)
    {
      return new
      {
        Project = project,
        ModifierId = modifierId
      };
    }
  }
}