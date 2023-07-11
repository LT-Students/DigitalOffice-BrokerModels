using System;

namespace DigitalOffice.Models.Broker.Models.Education;

public class EducationFilteredData
{
  public Guid Id { get; }
  public string UniversityName { get; }
  public Guid UserId { get; }

  public EducationFilteredData(Guid id, string universityName, Guid userId)
  {
    Id = id;
    UniversityName = universityName;
    UserId = userId;
  }
}