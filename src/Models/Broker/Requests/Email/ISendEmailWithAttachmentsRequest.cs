﻿using DigitalOffice.Models.Broker.Models.File;
using LT.DigitalOffice.Models.Broker.Requests.Image;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Email;

public interface ISendEmailWithAttachmentsRequest
{
  List<string> Receivers { get; }
  string Subject { get; }
  string Text { get; }
  IGetImagesRequest Images { get; }
  List<FilePathData> Files { get; }
  Guid? SenderId { get; }

  static object CreateObj(
      List<string> receivers,
      string subject,
      string text,
      IGetImagesRequest images,
      List<FilePathData> files,
      Guid? senderId = null)
  {
    return new
    {
      SenderId = senderId,
      Receivers = receivers,
      Subject = subject,
      Text = text,
      Images = images,
      Files = files
    };
  }
}
