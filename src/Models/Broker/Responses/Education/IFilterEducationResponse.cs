using LT.DigitalOffice.Models.Broker.Models.Education;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Education;

public interface IFilterEducationResponse
{
  List<EducationFilteredData> Education { get; }

  static object CreateObj(List<EducationFilteredData> education)
  {
    return new
    {
      Education = education
    };
  }
}