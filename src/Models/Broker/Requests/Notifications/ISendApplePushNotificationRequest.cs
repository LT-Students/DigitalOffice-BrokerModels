using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Notifications
{
  public interface ISendApplePushNotificationRequest
  {
    /// <summary>
    /// Users.
    /// </summary>
    List<Guid> UserIds { get; }

    /// <summary>
    /// Title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Subtitle.
    /// </summary>
    public string Subtitle { get; set; }

    /// <summary>
    /// Body.
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Type.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Badge value.
    /// </summary>
    public int? Badge { get; set; }

    /// <summary>
    /// Category.
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    /// Expiration.
    /// </summary>
    public DateTimeOffset? Expiration { get; set; }

    /// <summary>
    /// Priority.
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Collapse.
    /// </summary>
    public string CollapseId { get; set; }

    /// <summary>
    /// Custom properties.
    /// </summary>
    public Dictionary<string, CustomProperty> CustomProperties { get; set; }

    static object CreateObj(
      List<Guid> userIds,
      string title,
      string subtitle,
      string body,
      string type = "Alert",
      int? badge = null,
      string category = null,
      DateTimeOffset? expiration = null,
      int? priority = null,
      string collapseId = null,
      Dictionary<string, CustomProperty> customProperties = null)
    {
      return new
      {
        UserIds = userIds,
        Title = title,
        Subtitle = subtitle,
        Body = body,
        Type = type,
        Badge = badge,
        Category = category,
        Expiration = expiration,
        Priority = priority,
        CollapseId = collapseId,
        CustomProperties = customProperties
      };
    }
  }
}
