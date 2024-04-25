using DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Digest;

public class DigestFileData
{
  public Guid Id { get; }
  public DigestLanguage Language { get; }

  public DigestFileData(Guid id, DigestLanguage language)
  {
    Id = id;
    Language = language;
  }
}