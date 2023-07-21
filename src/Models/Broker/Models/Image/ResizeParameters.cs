namespace DigitalOffice.Models.Broker.Models.Image;

public class ResizeParameters
{
  public int? MaxResizeValue { get; }
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
