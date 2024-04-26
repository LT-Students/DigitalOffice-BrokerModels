using DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Digest;

public class DigestFileData
{
  public Guid Id { get; }
  public Locale Localization { get; }

  public DigestFileData(Guid id, Locale localization)
  {
    Id = id;
    Localization = localization;
  }
}