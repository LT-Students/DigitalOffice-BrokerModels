using System;

namespace DigitalOffice.Models.Broker.Models.Office;

public class OfficeSearchData
{
  /// <summary>
  /// Unique office identifier.
  /// </summary>
  public Guid Id { get; }

  /// <summary>
  /// Office name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Office adress.
  /// </summary>
  public string Address { get; }

  /// <summary>
  /// Office start time.
  /// </summary>
  public TimeSpan? StartTime { get; }

  /// <summary>
  /// Office end time.
  /// </summary>
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
