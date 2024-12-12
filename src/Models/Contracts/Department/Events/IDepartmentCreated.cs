using System;

namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IDepartmentCreated
  {
    DepartmentInfo Department { get; }
    Guid CreatorId { get; }

    static object CreateObj(
      DepartmentInfo department,
      Guid creatorId)
    {
      return new
      {
        Department = department,
        CreatorId = creatorId
      };
    }
  }
}