namespace LT.DigitalOffice.Models.Broker.Requests.News;

public interface ISearchNewsRequest
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
