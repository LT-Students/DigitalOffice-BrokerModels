using System;

namespace DigitalOffice.Models.Contracts.Time;

public record WorkTimeMonthLimitInfo
{
  /// <summary>
  /// Work time month limit id
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Work time month limit month
  /// </summary>
  public int Month { get; set; }

  /// <summary>
  /// Work time month limit year
  /// </summary>
  public int Year { get; set; }

  /// <summary>
  /// Work time month limit norm hours
  /// </summary>
  public float NormHours { get; set; }

  /// <summary>
  /// Work time month limit holidays
  /// </summary>
  public string Holidays { get; set; }
}
