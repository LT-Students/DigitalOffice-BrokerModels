using System;

namespace LT.DigitalOffice.Models.Broker.Models.Image
{
    public class ImageData
    {
        public Guid ImageId { get; }
        public Guid? ParentId { get; }
        public string Content { get; }
        public string Extension { get; }
        public string Name { get; }

        public ImageData(
            Guid imageId,
            Guid? parentId,
            string content,
            string extension,
            string name)
        {
            ImageId = imageId;
            ParentId = parentId;
            Content = content;
            Extension = extension;
            Name = name;
        }
    }
}
