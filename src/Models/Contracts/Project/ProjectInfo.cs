using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Project
{
  public record ProjectInfo
  {
    public Guid Id { get; init; }
    public Guid? DepartmentId { get; init; }
    public int Status { get; init; }
    public string Name { get; init; }
    public string ShortName { get; init; }
    public string Description { get; init; }
    public string ShortDescription { get; init; }
    public string Customer { get; init; }
    public DateTime StartDateUtc { get; init; }
    public DateTime? EndDateUtc { get; init; }
    public List<ProjectUserInfo> Users { get; init; }
    public List<Guid> Images { get; init; }
    public List<Guid> Files { get; init; }
    public List<ProjectUserCreateDateInfo> UserCreateDates { get; init; }
    public List<ProjectUserRemoveDateInfo> UserRemoveDates { get; init; }

    public ProjectInfo(
      Guid id,
      int status,
      string name,
      string shortName,
      string description,
      string shortDescription,
      string customer,
      DateTime startDateUtc,
      DateTime? endDateUtc,
      Guid? departmentId,
      List<ProjectUserInfo> users,
      List<Guid> images,
      List<Guid> files,
      List<ProjectUserCreateDateInfo> userCreateDates = null,
      List<ProjectUserRemoveDateInfo> userRemoveDates = null)
    {
      Id = id;
      Status = status;
      Name = name;
      ShortName = shortName;
      Description = description;
      ShortDescription = shortDescription;
      Customer = customer;
      StartDateUtc = startDateUtc;
      EndDateUtc = endDateUtc;
      DepartmentId = departmentId;
      Users = users;
      Images = images;
      Files = files;
      UserCreateDates = userCreateDates;
      UserRemoveDates = userRemoveDates;
    }
  }
}