using LT.DigitalOffice.Models.Broker.Models.Office;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Office;

public interface IFilterOfficesResponse
{
  List<OfficeFilteredData> Offices { get; }

  static object CreateObj(List<OfficeFilteredData> offices)
  {
    return new
    {
      Offices = offices
    };
  }
}
