namespace LT.DigitalOffice.Models.Broker.Models.Image
{
    public class CreateImageData
    {
        public string Name { get; }
        public string Content { get; }
        public string Extension { get; }

        public CreateImageData(string name, string content, string extension)
        {
            Name = name;
            Content = content;
            Extension = extension;
        }
    }
}
