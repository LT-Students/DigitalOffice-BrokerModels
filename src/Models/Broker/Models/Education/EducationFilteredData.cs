using System;

namespace DigitalOffice.Models.Broker.Models.Education;

public class EducationFilteredData
{
  public string UniversityName { get; }
  public Guid UserId { get; }

  public EducationFilteredData(string universityName, Guid userId)
  {
    UniversityName = universityName;
    UserId = userId;
  }
}