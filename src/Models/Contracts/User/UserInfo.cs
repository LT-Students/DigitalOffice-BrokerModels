using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.User
{
  /// <summary>
  /// User information.
  /// </summary>
  public record UserInfo(
    Guid Id,
    Guid? AvatarId,
    string FirstName,
    string LastName,
    string MiddleName,
    string Gender,
    string DateOfBirth,
    DateTime? BusinessHoursFromUtc,
    DateTime? BusinessHoursToUtc,
    double? Latitude,
    double? Longitude,
    bool IsAdmin,
    bool IsActive,
    bool IsPending,
    List<UserCommunicationInfo> Communications)
  {
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; init; } = Id;

    /// <summary>
    /// Avatar ID to get from ImageService.
    /// </summary>
    public Guid? AvatarId { get; init; } = AvatarId;

    /// <summary>
    /// First name.
    /// </summary>
    public string FirstName { get; init; } = FirstName;

    /// <summary>
    /// Last name.
    /// </summary>
    public string LastName { get; init; } = LastName;

    /// <summary>
    /// Middle name.
    /// </summary>
    public string MiddleName { get; init; } = MiddleName;

    /// <summary>
    /// Gender.
    /// </summary>
    public string Gender { get; init; } = Gender;

    /// <summary>
    /// User birthdate.
    /// </summary>
    public string DateOfBirth { get; init; } = DateOfBirth;

    /// <summary>
    /// Time when user starts to work.
    /// </summary>
    public DateTime? BusinessHoursFromUtc { get; init; } = BusinessHoursFromUtc;

    /// <summary>
    /// Time when user stops to work.
    /// </summary>
    public DateTime? BusinessHoursToUtc { get; init; } = BusinessHoursToUtc;

    /// <summary>
    /// User location latitude.
    /// </summary>
    public double? Latitude { get; init; } = Latitude;

    /// <summary>
    /// User location longitude.
    /// </summary>
    public double? Longitude { get; init; } = Longitude;

    /// <summary>
    /// User admin status.
    /// </summary>
    public bool IsAdmin { get; init; } = IsAdmin;

    /// <summary>
    /// User status.
    /// </summary>
    public bool IsActive { get; init; } = IsActive;

    /// <summary>
    /// User activation status.
    /// </summary>
    public bool IsPending { get; init; } = IsPending;

    /// <summary>
    /// User communications.
    /// </summary>
    public List<UserCommunicationInfo> Communications { get; init; } = Communications;
  }
}
