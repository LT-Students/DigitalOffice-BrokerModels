using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Notifications
{
  public interface ISendPushNotificationRequest
  {
    List<Guid> UserIds { get; }
    string NotificationText { get; }

    static object CreateObj(List<Guid> userIds, string notificationText)
    {
      return new
      {
        UserIds = userIds,
        NotificationText = notificationText
      };
    }
  }
}
