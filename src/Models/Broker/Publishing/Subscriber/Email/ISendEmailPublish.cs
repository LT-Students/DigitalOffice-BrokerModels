using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Email;


public interface ISendEmailPublish
{
  string Receiver { get; }
  string Subject { get; }
  string Text { get; }
  Guid? SenderId { get; }

  static object CreateObj(
      string receiver,
      string subject,
      string text,
      Guid? senderId = null)
  {
    return new
    {
      SenderId = senderId,
      Receiver = receiver,
      Subject = subject,
      Text = text
    };
  }
}
