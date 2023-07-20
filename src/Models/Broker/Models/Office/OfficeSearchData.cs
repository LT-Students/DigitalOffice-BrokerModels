using System;

namespace DigitalOffice.Models.Broker.Models.Office;

public class OfficeSearchData
{
  public Guid Id { get; }
  public string Name { get; }
  public string Address { get; }
  public TimeSpan? StartTime { get; }
  public TimeSpan? EndTime { get; }

  public OfficeSearchData(Guid id, string name, string address, TimeSpan? startTime, TimeSpan? endTime)
  {
    Id = id;
    Name = name;
    Address = address;
    StartTime = startTime;
    EndTime = endTime;
  }
}
