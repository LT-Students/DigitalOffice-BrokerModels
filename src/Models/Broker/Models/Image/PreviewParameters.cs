namespace DigitalOffice.Models.Broker.Models.Image;

public class PreviewParameters
{
  /// <summary>
  /// Image width to height resolution ratio
  /// </summary>
  public int? ConditionalWidth { get; }

  /// <summary>
  /// Image height to width resolution ratio
  /// </summary>
  public int? ConditionalHeight { get; }

  /// <summary>
  /// The highest acceptable image resolution in height and width
  /// </summary>
  public int? ResizeMaxValue { get; }

  /// <summary>
  /// Highest desired image weight
  /// </summary>
  public int? MaxSizeCompress { get; }

  public PreviewParameters(
      int? conditionalWidth,
      int? conditionalHeight,
      int? resizeMaxValue,
      int? maxSizeCompress)
  {
    ConditionalWidth = conditionalWidth;
    ConditionalHeight = conditionalHeight;
    ResizeMaxValue = resizeMaxValue;
    MaxSizeCompress = maxSizeCompress;
  }
}
