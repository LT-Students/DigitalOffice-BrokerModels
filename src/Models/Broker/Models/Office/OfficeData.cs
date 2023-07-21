using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Office;

public class OfficeData
{
  public Guid Id { get; }
  public string Name { get; }
  public string City { get; }
  public string Address { get; }
  public double? Latitude { get; set; }
  public double? Longitude { get; set; }
  public List<Guid> UsersIds { get; }

  public OfficeData(
      Guid id,
      string name,
      string city,
      string address,
      double? latitude,
      double? longitude,
      List<Guid> usersIds)
  {
    Id = id;
    Name = name;
    City = city;
    Address = address;
    Latitude = latitude;
    Longitude = longitude;
    UsersIds = usersIds;
  }
}
