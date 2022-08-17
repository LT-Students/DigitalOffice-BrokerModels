using System;

namespace LT.DigitalOffice.Models.Broker.Models.File
{
    public class FileCharacteristicsData
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Extension { get; }
        public long Size { get; }
        public DateTime CreatedAtUtc { get; }

        public FileCharacteristicsData(
            Guid id,
            string name,
            string extension,
            long size,
            DateTime createdAtUtc)
        {
            Id = id;
            Name = name;
            Extension = extension;
            Size = size;
            CreatedAtUtc = createdAtUtc;
        }
    }
}
