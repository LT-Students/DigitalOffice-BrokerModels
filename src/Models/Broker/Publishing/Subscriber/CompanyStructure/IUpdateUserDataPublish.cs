using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IUpdateUserDataPublish
{
  Guid UserId { get; set; }
  string FirstName { get; set; }
  string MiddleName { get; set; }
  string LastName { get; set; }
  Guid? AvatarId { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    Guid userId,
    string firstName,
    string middleName,
    string lastName,
    Guid? avatarId,
    Guid modifiedBy)
  {
    return new
    {
      UserId = userId,
      FirstName = firstName,
      MiddleName = middleName,
      LastName = lastName,
      AvatarId = avatarId,
      ModifiedBy = modifiedBy
    };
  }
}
