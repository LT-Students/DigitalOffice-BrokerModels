using System;

namespace LT.DigitalOffice.Models.Broker.Responses.TextTemplate;

public interface IGetTextTemplateResponse
{
  Guid Id { get; }
  string Subject { get; }
  string Text { get; }
  string Locale { get; }

  static object CreateObj(Guid id, string subject, string text, string locale)
  {
    return new
    {
      Id = id,
      Subject = subject,
      Text = text,
      Locale = locale
    };
  }
}
