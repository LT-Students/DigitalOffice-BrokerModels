using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Office.Events
{
  public interface IGetOfficesResponse
  {
    List<OfficeInfo> Offices { get; set; }

    static object CreateObj(List<OfficeInfo> offices)
    {
      return new { Offices = offices };
    }
  }
}