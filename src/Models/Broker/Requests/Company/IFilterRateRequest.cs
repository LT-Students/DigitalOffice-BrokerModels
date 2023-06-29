namespace LT.DigitalOffice.Models.Broker.Requests.Company;

public interface IFilterRateRequest
{
  double Rate { get; }

  static object CreateObj(double? rate)
  {
    return new
    {
      Rate = rate
    };
  }
}