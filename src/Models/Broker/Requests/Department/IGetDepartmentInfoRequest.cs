using System;

namespace DigitalOffice.Models.Broker.Requests.Department
{
  public interface IGetDepartmentInfoRequest
  {
    public Guid DepartmentId { get; }

    static object CreateObj(Guid departmentId)
    {
      return new
      {
        DepartmentId = departmentId
      };
    }
  }
}