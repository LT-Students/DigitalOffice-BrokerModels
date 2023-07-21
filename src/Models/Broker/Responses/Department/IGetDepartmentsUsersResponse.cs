using LT.DigitalOffice.Models.Broker.Models.Department;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Department;

public interface IGetDepartmentsUsersResponse
{
  List<DepartmentUserExtendedData> Users { get; }

  static object CreateObj(List<DepartmentUserExtendedData> users)
  {
    return new
    {
      Users = users
    };
  }
}
