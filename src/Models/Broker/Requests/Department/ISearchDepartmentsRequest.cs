namespace LT.DigitalOffice.Models.Broker.Requests.Department;

public interface ISearchDepartmentsRequest
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
