using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IUpdateDepartmentDataPublish
{
  Guid DepartmentId { get; set; }
  string Name { get; set; }
  string Description { get; set; }
  bool? IsActive { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    Guid departmentId,
    string name,
    string description,
    bool? isActive,
    Guid modifiedBy)
  {
    return new
    {
      DepartmentId = departmentId,
      Name = name,
      Description = description,
      IsActive = isActive,
      ModifiedBy = modifiedBy
    };
  }
}
