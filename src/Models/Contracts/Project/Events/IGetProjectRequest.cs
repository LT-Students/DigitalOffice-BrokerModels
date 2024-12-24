using System;

namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IGetProjectRequest
  {
    public Guid ProjectId { get; }

    static object CreateObj(Guid projectId)
    {
      return new
      {
        ProjectId = projectId
      };
    }
  }
}