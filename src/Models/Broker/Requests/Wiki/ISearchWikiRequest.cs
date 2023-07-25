namespace DigitalOffice.Models.Broker.Requests.Wiki;
public interface ISearchWikiRequest
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