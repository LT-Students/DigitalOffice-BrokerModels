using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Office
{
  public record OfficeInfo
  {
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string City { get; init; }
    public string Address { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public List<Guid> UserIds { get; init; }

    public OfficeInfo(
      Guid id,
      string name,
      string city,
      string address,
      double? latitude,
      double? longitude,
      List<Guid> userIds)
    {
      Id = id;
      Name = name;
      City = city;
      Address = address;
      Latitude = latitude;
      Longitude = longitude;
      UserIds = userIds;
    }
  }
}