using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;

namespace LT.DigitalOffice.Models.Broker.Responses.Department;

public interface IGetDepartmentUserRoleResponse
{
  DepartmentUserRole? DepartmentUserRole { get; }
  DepartmentUserAssignment? DepartmentUserAssignment { get; }

  static object CreateObj(
    DepartmentUserRole? departmentUserRole,
    DepartmentUserAssignment? departmentUserAssignment)
  {
    return new
    {
      DepartmentUserRole = departmentUserRole,
      DepartmentUserAssignment = departmentUserAssignment
    };
  }
}
