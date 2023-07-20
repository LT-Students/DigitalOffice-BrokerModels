using LT.DigitalOffice.Models.Broker.Models.Office;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Office;

public interface IGetOfficesResponse
{
  List<OfficeData> Offices { get; }

  static object CreateObj(
      List<OfficeData> offices)
  {
    return new
    {
      Offices = offices
    };
  }
}
