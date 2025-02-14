namespace DigitalOffice.Models.Contracts.Time.Events;

public interface IGetWorkTimeMonthLimitsResponse
{
  WorkTimeMonthLimitInfo[] WorkTimeMonthLimits { get; }

  static object CreateObj(WorkTimeMonthLimitInfo[] workTimeMonthLimits)
  {
    return new
    {
      WorkTimeMonthLimits = workTimeMonthLimits
    };
  }
}
