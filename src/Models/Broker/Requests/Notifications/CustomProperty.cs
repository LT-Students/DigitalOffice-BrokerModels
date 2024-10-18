namespace LT.DigitalOffice.Models.Broker.Requests.Notifications;

/// <summary>
/// Custom property model.
/// </summary>
public class CustomProperty
{
  /// <summary>
  /// Property value.
  /// </summary>
  public object Value { get; set; }

  /// <summary>
  /// Whether it is an APS property.
  /// </summary>
  public bool IsApsProperty { get; set; }
}
