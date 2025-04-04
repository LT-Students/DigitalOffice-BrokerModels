using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IGetProjectsRequest
  {
    public List<Guid> ProjectIds { get; set; }
    public List<Guid> UserIds { get; set; }
    public ProjectUserRoleType? Role { get; set; }
    public bool IncludeCreateDate { get; set; }
    public bool IncludeRemoveDate { get; set; }

    static object CreateObj(
      bool includeCreateDate,
      bool includeRemoveDate,
      List<Guid> projectIds = null,
      List<Guid> userIds = null,
      ProjectUserRoleType? role = null)
    {
      return new
      {
        DepartmentIds = projectIds,
        UserIds = userIds,
        Role = role,
        IncludeCreateDate = includeCreateDate,
        IncludeRemoveDate = includeRemoveDate
      };
    }
  }
}