using System;

namespace DigitalOffice.Models.Broker.Models.News;

public class NewsSearchData
{
  public Guid Id { get; }
  public string Subject { get; }
  public string Content { get; }

  public NewsSearchData(Guid id, string subject, string content)
  {
    Id = id;
    Subject = subject;
    Content = content;
  }
}
