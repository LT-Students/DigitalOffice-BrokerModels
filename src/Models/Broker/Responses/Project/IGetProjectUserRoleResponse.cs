using LT.DigitalOffice.Models.Broker.Enums;

namespace LT.DigitalOffice.Models.Broker.Responses.Project;

public interface IGetProjectUserRoleResponse
{
  ProjectStatusType ProjectStatus { get; }
  ProjectUserRoleType? ProjectUserRole { get; }

  static object CreateObj(
      ProjectStatusType projectStatus,
      ProjectUserRoleType? projectUserRole)
  {
    return new
    {
      ProjectStatus = projectStatus,
      ProjectUserRole = projectUserRole
    };
  }
}
