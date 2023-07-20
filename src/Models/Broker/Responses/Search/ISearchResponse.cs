using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Search;

public interface ISearchResponse<T>
{
  List<T> Values { get; }
  int TotalCount { get; }

  static object CreateObj(List<T> values)
  {
    return new
    {
      Values = values,
      TotalCount = values.Count
    };
  }
}
