using System.Collections.Generic;
using DigitalOffice.Models.Broker.Models.Education;

namespace DigitalOffice.Models.Broker.Responses.Education;

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