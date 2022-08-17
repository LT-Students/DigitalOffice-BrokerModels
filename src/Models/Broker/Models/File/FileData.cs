using System;

namespace LT.DigitalOffice.Models.Broker.Models.File
{
    public class FileData
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Content { get; }
        public string Extension { get; }

        public FileData(
            Guid id,
            string name,
            string content,
            string extension)
        {
            Id = id;
            Name = name;
            Content = content;
            Extension = extension;
        }
    }
}
