namespace LT.DigitalOffice.Models.Broker.Requests.Office;

public interface ISearchOfficesRequest
{
  string[] Value { get; }

  static object CreateObj(string[] value)
  {
    return new
    {
      Value = value
    };
  }
}
