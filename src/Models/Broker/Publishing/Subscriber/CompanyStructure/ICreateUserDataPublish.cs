using DigitalOffice.Models.Broker.Models.User;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface ICreateUserDataPublish
{
  Guid UserId { get; set; }
  public Guid? DepartmentId { get; set; }
  string FirstName { get; set; }
  string MiddleName { get; set; }
  string LastName { get; set; }
  public Guid? PositionId { get; set; }
  public Guid? RoleId { get; set; }
  Guid? AvatarId { get; set; }
  List<UserCommunicationData> Communications { get; set; }
  Guid CreatedBy { get; set; }
  DateTime CreatedAtUtc { get; set; }

  static object CreateObj(
    Guid userId,
    Guid? departmentId,
    string firstName,
    string middleName,
    string lastName,
    Guid? positionId,
    Guid? roleId,
    Guid? avatarId,
    List<UserCommunicationData> communications,
    Guid createdBy,
    DateTime createdAtUtc)
  {
    return new
    {
      UserId = userId,
      DepartmentId = departmentId,
      FirstName = firstName,
      MiddleName = middleName,
      LastName = lastName,
      PositionId = positionId,
      RoleId = roleId,
      AvatarId = avatarId,
      Communications = communications,
      ModifiedBy = createdBy,
      CreatedAtUtc = createdAtUtc
    };
  }
}