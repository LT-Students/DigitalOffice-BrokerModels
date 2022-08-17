using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Project
{
  public interface IGetProjectsRequest
  {
    List<Guid> ProjectsIds { get; }
    List<Guid> UsersIds { get; }
    List<Guid> DepartmentsIds { get; }
    bool IncludeDepartment { get; }
    bool IncludeUsers { get; }

    static object CreateObj(
        List<Guid> projectsIds = null,
        List<Guid> usersIds = null,
        List<Guid> departmentsIds = null,
        bool includeDepartment = false,
        bool includeUsers = false)
    {
      return new
      {
        ProjectsIds = projectsIds,
        UsersIds = usersIds,
        DepartmentsIds = departmentsIds,
        IncludeDepartment = includeDepartment,
        IncludeUsers = includeUsers
      };
    }
  }
}
