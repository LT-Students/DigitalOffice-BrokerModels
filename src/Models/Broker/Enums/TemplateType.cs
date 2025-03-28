using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LT.DigitalOffice.Models.Broker.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum TemplateType
{
  Notification = 0,
  Warning = 1,
  Greeting = 2,
  PasswordRecovery = 3,
  ConfirmСommunication = 4,
  UserRecovery = 5,
  SmtpCheck = 6,
  WorkTimeWithoutLeaveTime = 7,
  FeedbackReply = 8,
  SurveyCreated = 9,
  SurveyReminder = 10,
  FeedbackReceived = 11,
  WorkingHoursReminderPushNotification = 12,
  PlannedVacationInTwoWeeks = 13,
  PlannedVacationInTwoWeeksManager = 14,
  PlannedVacationInOneDay = 15,
  WorkTimeWithLeaveTime = 16,
  AddProjectUserSuccess = 17,
  AddProjectUserFailure = 18,
  RemoveProjectUserSuccess = 19,
  RemoveProjectUserFailure = 20,
  AddDepartmentUserSuccess = 21,
  AddDepartmentUserFailure = 22,
  ArchiveUserSuccess = 23,
  ArchiveUserFailure = 24,
  Offer = 25
}
