using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Notifications
{
  public interface ISendAndroidTopicNotificationRequest
  {
    /// <summary>
    /// Topic name.
    /// </summary>
    public string TopicName { get; set; }

    /// <summary>
    /// Title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Body.
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Image url.
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Custom properties.
    /// </summary>
    public Dictionary<string, CustomProperty> CustomProperties { get; set; }

    static object CreateObj(
      string topicName,
      string title,
      string body,
      string imageUrl,
      Dictionary<string, CustomProperty> customProperties = null)
    {
      return new
      {
        TopicName = topicName,
        Title = title,
        Body = body,
        ImageUrl = imageUrl,
        CustomProperties = customProperties
      };
    }
  }
}