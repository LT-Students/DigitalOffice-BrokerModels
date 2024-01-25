using System;

namespace DigitalOffice.Models.Broker.Models.User;

public class UserData
{
  public Guid Id { get; }
  public Guid? ImageId { get; }
  public string FirstName { get; }
  public string MiddleName { get; }
  public string LastName { get; }
  public bool IsActive { get; }
  public bool IsPending { get; }
  public string Email { get; }

  public UserData(
      Guid id,
      Guid? imageId,
      string firstName,
      string middleName,
      string lastName,
      bool isActive,
      bool isPending,
      string email = null)
  {
    Id = id;
    ImageId = imageId;
    FirstName = firstName;
    MiddleName = middleName;
    LastName = lastName;
    IsActive = isActive;
    IsPending = isPending;
    Email = email;
  }
}
