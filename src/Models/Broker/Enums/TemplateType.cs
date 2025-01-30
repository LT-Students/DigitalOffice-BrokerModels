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
  EmptyUserWorktimes = 7,
  FeedbackReply = 8,
  SurveyCreated = 9,
  SurveyReminder = 10,
  FeedbackReceived = 11,
  WorkingHoursReminderPushNotification = 12,
  PlannedVacationInTwoWeeks = 13,
  PlannedVacationInTwoWeeksManager = 14,
  PlannedVacationInOneDay = 15
}
