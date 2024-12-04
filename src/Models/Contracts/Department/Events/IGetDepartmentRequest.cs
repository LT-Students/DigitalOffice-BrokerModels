using System;

namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IGetDepartmentRequest
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