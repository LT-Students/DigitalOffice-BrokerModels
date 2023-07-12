using System.Collections.Generic;
using LT.DigitalOffice.Models.Broker.Models.Education;

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