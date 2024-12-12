using System;

namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IDepartmentUpdated
  {
    DepartmentInfo Department { get; }
    Guid ModifierId { get; }

    static object CreateObj(
      DepartmentInfo department,
      Guid modifierId)
    {
      return new
      {
        Department = department,
        ModifierId = modifierId
      };
    }
  }
}