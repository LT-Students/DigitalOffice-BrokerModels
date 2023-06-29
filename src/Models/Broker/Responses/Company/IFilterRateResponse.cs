using LT.DigitalOffice.Models.Broker.Models.Company;

namespace LT.DigitalOffice.Models.Broker.Responses.Company;

public interface IFilterRateResponse
{
  RateFilteredData RateData { get; }

  static object CreateObj(RateFilteredData rateData)
  {
    return new
    {
      RateData = rateData
    };
  }
}