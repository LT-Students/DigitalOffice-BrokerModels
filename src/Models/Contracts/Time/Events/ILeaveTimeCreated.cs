using System;

namespace LT.DigitalOffice.Models.Contracts.Time.Events;

public interface ILeaveTimeCreated
{
  /// <summary>
  /// Id of user who will leave.
  /// </summary>
  Guid UserId { get; set; }

  /// <summary>
  /// For how long user will leave.
  /// </summary>
  int Minutes { get; set; }

  /// <summary>
  /// Start of leave.
  /// </summary>
  DateTimeOffset StartTime { get; set; }

  /// <summary>
  /// End of leave.
  /// </summary>
  DateTimeOffset? EndTime { get; set; }

  /// <summary>
  /// Type of leave.
  /// </summary>
  LeaveType LeaveType { get; set; }

  /// <summary>
  /// Comment to leave.
  /// </summary>
  string Comment { get; set; }

  static object CreateObj(
      Guid userId,
      int minutes,
      DateTimeOffset startTime,
      DateTimeOffset endTime,
      LeaveType leaveType,
      string comment)
  {
    return new
    {
      UserId = userId,
      Minutes = minutes,
      StartTime = startTime,
      EndTime = endTime,
      LeaveType = leaveType,
      Comment = comment
    };
  }
}
