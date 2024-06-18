using DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Digest;

public class DigestFileData
{
  public Guid Id { get; }
  public string Name { get; }
  public Locale Localization { get; }

  public DigestFileData(Guid id, string name, Locale localization)
  {
    Id = id;
    Name = name;
    Localization = localization;
  }
}