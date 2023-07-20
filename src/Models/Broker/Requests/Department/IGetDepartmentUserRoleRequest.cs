using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Department;

public interface IGetDepartmentUserRoleRequest
{
  Guid DepartmentId { get; }
  Guid UserId { get; }

  static object CreateObj(
      Guid departmentId,
      Guid userId)
  {
    return new
    {
      DepartmentId = departmentId,
      UserId = userId
    };
  }
}
