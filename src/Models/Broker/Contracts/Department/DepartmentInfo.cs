using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Contracts.Department
{
  public record DepartmentInfo
  {
    public Guid Id { get; }
    public string Name { get; }
    public string ShortName { get; }
    public string Description { get; }
    public bool IsActive { get; }
    public Guid? ParentId { get; }
    public CategoryInfo Category { get; }
    public List<DepartmentUserInfo> Users { get; }

    public DepartmentInfo(
      Guid id,
      string name,
      string shortName,
      string description,
      bool isActive,
      Guid? parentId,
      CategoryInfo category,
      List<DepartmentUserInfo> users = null)
    {
      Id = id;
      Name = name;
      ShortName = shortName;
      Description = description;
      IsActive = isActive;
      ParentId = parentId;
      Category = category;
      Users = users;
    }
  }
}
