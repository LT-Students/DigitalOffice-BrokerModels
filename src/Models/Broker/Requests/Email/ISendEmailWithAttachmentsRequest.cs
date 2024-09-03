using DigitalOffice.Models.Broker.Models.Digest;
using DigitalOffice.Models.Broker.Models.File;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Email;

public interface ISendEmailWithAttachmentsRequest
{
  List<string> Receivers { get; }
  string Subject { get; }
  string Text { get; }
  List<Guid> ImageIds { get; }
  List<FilePathData> Files { get; }
  Guid? SenderId { get; }

  static object CreateObj(
      List<string> receivers,
      string subject,
      string text,
      List<Guid> imageIds,
      List<FilePathData> files,
      Guid? senderId = null)
  {
    return new
    {
      SenderId = senderId,
      Receivers = receivers,
      Subject = subject,
      Text = text,
      ImageIds = imageIds,
      Files = files
    };
  }
}
