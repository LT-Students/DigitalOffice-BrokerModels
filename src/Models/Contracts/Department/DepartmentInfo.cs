using DigitalOffice.Models.Contracts.Department;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Contracts.Department
{
  public record DepartmentInfo
  {
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string ShortName { get; init; }
    public string Description { get; init; }
    public bool IsActive { get; init; }
    public Guid? ParentId { get; init; }
    public CategoryInfo Category { get; init; }
    public List<DepartmentUserInfo> Users { get; init; }
    public List<DepartmentUserCreateDateInfo> CreateDateInfos { get; init; }

    public DepartmentInfo(
      Guid id,
      string name,
      string shortName,
      string description,
      bool isActive,
      Guid? parentId,
      CategoryInfo category,
      List<DepartmentUserInfo> users = null,
      List<DepartmentUserCreateDateInfo> createDateInfos = null)
    {
      Id = id;
      Name = name;
      ShortName = shortName;
      Description = description;
      IsActive = isActive;
      ParentId = parentId;
      Category = category;
      Users = users;
      CreateDateInfos = createDateInfos;
    }
  }
}
