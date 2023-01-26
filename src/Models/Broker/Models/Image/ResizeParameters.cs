namespace DigitalOffice.Models.Broker.Models.Image
{
    public class ResizeParameters
    {
        public int? MaxResizeValue { get; }
        public PreviewParameters PreviewParameters { get; }

        public ResizeParameters(
            int? maxResizeValue,
            PreviewParameters previewParameters)
        {
            MaxResizeValue = maxResizeValue;
            PreviewParameters = previewParameters;
        }
    }
}
