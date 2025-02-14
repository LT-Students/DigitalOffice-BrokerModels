namespace DigitalOffice.Models.Contracts.Time.Events;

public interface IGetWorkTimeMonthLimitsRequest
{
  /// <summary>
  /// Year of limits.
  /// </summary>
  public int? Year { get; set; }

  /// <summary>
  /// Month of limits.
  /// </summary>
  public int? Month { get; set; }

  static object CreateObj(
    int? year,
    int? month)
  {
    return new
    {
      Year = year,
      Month = month
    };
  }
}
