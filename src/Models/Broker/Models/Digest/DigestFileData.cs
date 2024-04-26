using DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Digest;

public class DigestFileData
{
  public Guid Id { get; }
  public Locale Language { get; }

  public DigestFileData(Guid id, Locale language)
  {
    Id = id;
    Language = language;
  }
}