using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Education;

public interface IFilterEducationRequest
{
  List<string> UniversitiesNames { get; }

  static object CreateObj(List<string> universitiesNames)
  {
    return new
    {
      UniversitiesNames = universitiesNames,
    };
  }
}