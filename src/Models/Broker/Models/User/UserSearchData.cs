using System;

namespace DigitalOffice.Models.Broker.Models.User;

public class UserSearchData
{
  /// <summary>
  /// Unique user identifier.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// The user first name.
  /// </summary>
  public string FirstName { get; }

  /// <summary>
  /// The user last name.
  /// </summary>
  public string LastName { get; }

  /// <summary>
  /// The user middle name.
  /// </summary>
  public string MiddleName { get; }

  public UserSearchData(Guid id, string firstName, string lastName, string middleName)
  {
    Id = id;
    FirstName = firstName;
    LastName = lastName;
    MiddleName = middleName;
  }
}
