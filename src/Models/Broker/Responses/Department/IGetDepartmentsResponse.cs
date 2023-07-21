using LT.DigitalOffice.Models.Broker.Models.Department;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Department;

public interface IGetDepartmentsResponse
{
  List<DepartmentData> Departments { get; }

  static object CreateObj(
      List<DepartmentData> departments)
  {
    return new
    {
      Departments = departments
    };
  }
}