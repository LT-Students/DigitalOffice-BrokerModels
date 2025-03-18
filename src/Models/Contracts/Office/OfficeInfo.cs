using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Office
{
  public record OfficeInfo
  {
    public Guid Id { get; }
    public string Name { get; }
    public string City { get; }
    public string Address { get; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public List<Guid> UserIds { get; }

    public OfficeInfo(
      Guid id,
      string name,
      string city,
      string address,
      double? latitude,
      double? longitude,
      List<Guid> userTds)
    {
      Id = id;
      Name = name;
      City = city;
      Address = address;
      Latitude = latitude;
      Longitude = longitude;
      UserIds = userTds;
    }
  }
}