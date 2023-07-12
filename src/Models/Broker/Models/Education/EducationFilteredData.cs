using System;

namespace DigitalOffice.Models.Broker.Models.Education;

public class EducationFilteredData
{
  public Guid Id { get; }
  public Guid UserId { get; }
  public string UniversityName { get; }

  public EducationFilteredData(Guid id, Guid userId, string universityName)
  {
    Id = id;
    UserId = userId;
    UniversityName = universityName;
  }
}