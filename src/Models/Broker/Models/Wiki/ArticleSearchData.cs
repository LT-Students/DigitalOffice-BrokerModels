using System;

namespace DigitalOffice.Models.Broker.Models.Wiki;

  public class ArticleSearchData
  {
    /// <summary>
    /// Article Unique identifier.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Article name.
    /// </summary>
    public string Name { get; }

    public ArticleSearchData(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
  }
