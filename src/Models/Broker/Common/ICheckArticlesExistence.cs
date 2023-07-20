using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckArticlesExistence
{
  List<Guid> ArticlesIds { get; }

  static object CreateObj(List<Guid> articlesIds)
  {
    return new
    {
      ArticlesIds = articlesIds
    };
  }
}
