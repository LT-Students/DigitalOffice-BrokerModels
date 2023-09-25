namespace DigitalOffice.Models.Broker.Models.Image;

public class ResizeParameters
{
  /// <summary>
  /// The highest acceptable image resolution in height and width
  /// </summary>
  public int? MaxResizeValue { get; }

  /// <summary>
  /// Highest desired image weight
  /// </summary>
  public int? MaxSizeCompress { get; }
  public PreviewParameters PreviewParameters { get; }

  public ResizeParameters(
      int? maxResizeValue,
      int? maxSizeCompress,
      PreviewParameters previewParameters)
  {
    MaxResizeValue = maxResizeValue;
    MaxSizeCompress = maxSizeCompress;
    PreviewParameters = previewParameters;
  }
}
