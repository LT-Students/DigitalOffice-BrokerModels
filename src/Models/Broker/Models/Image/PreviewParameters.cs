namespace DigitalOffice.Models.Broker.Models.Image
{
    public class PreviewParameters
    {
        public int? ConditionalWidth { get; }
        public int? ConditionalHeight { get; }
        public int? ResizeMaxValue { get; }
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
}
