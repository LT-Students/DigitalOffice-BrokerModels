using System;

namespace DigitalOffice.Models.Broker.Models.News;

public class NewsSearchData
{
  /// <summary>
  /// The unique identifier for the news.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// The news subject.
  /// </summary>
  public string Subject { get; }

  /// <summary>
  /// The news content.
  /// </summary>
  public string Content { get; }

  public NewsSearchData(Guid id, string subject, string content)
  {
    Id = id;
    Subject = subject;
    Content = content;
  }
}
