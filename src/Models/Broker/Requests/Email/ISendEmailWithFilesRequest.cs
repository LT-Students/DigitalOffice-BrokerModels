using DigitalOffice.Models.Broker.Models.Digest;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Email;

public interface ISendEmailWithFilesRequest
{
  List<string> Receivers { get; }
  string Subject { get; }
  string Text { get; }
  Guid ImageId { get; }
  List<DigestFileData> Files { get; }
  Guid? SenderId { get; }

  static object CreateObj(
      List<string> receivers,
      string subject,
      string text,
      Guid imageId,
      List<DigestFileData> files,
      Guid? senderId = null)
  {
    return new
    {
      SenderId = senderId,
      Receivers = receivers,
      Subject = subject,
      Text = text,
      ImageId = imageId,
      Files = files
    };
  }
}
