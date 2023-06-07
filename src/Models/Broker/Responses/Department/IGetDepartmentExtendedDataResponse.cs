using DigitalOffice.Models.Broker.Models.Department;
using System.Collections.Generic;
using System;

namespace DigitalOffice.Models.Broker.Responses.Department;

public interface IGetDepartmentExtendedDataResponse
{
  Guid Id { get; }
  Guid? ParentId { get; }
  string Name { get; }
  string Description { get; }
  List<DepartmentUserRoleData> Users { get; }

  public static object CreateObj(
    Guid id,
    Guid? parentId,
    string name,
    string description,
    List<DepartmentUserRoleData> users)
  {
    return new
    {
      Id = id,
      ParentId = parentId,
      Name = name,
      Description = description,
      Users = users
    };
  }
}
