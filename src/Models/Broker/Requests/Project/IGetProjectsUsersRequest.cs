using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Project
{
  public interface IGetProjectsUsersRequest
  {
    List<Guid> UsersIds { get; }
    List<Guid> ProjectsIds { get; }
    DateTime? ByEntryDate { get; }

    static object CreateObj(
      List<Guid> usersIds = null,
      List<Guid> projectsIds = null,
      DateTime? byEntryDate = null)
    {
      return new
      {
        UsersIds = usersIds,
        ProjectsIds = projectsIds,
        ByEntryDate = byEntryDate
      };
    }
  }
}
