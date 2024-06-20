using DigitalOffice.Models.Broker.Models.Digest;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Email;

public interface ISendEmailWithFilesRequest
{
  string Receiver { get; }
  string Subject { get; }
  string Text { get; }
  List<DigestFileData> Files { get; }
  Guid? SenderId { get; }

  static object CreateObj(
      string receiver,
      string subject,
      string text,
      List<DigestFileData> files,
      Guid? senderId = null)
  {
    return new
    {
      SenderId = senderId,
      Receiver = receiver,
      Subject = subject,
      Text = text,
      Files = files
    };
  }
}
