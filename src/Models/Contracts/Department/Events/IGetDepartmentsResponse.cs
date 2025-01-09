using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IGetDepartmentsResponse
  {
    List<DepartmentInfo> Departments { get; }

    static object CreateObj(List<DepartmentInfo> departments)
    {
      return new
      {
        Departments = departments
      };
    }
  }
}
