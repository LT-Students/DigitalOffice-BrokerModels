using System;

namespace DigitalOffice.Models.Broker.Models.Office
{
    public class OfficeSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public OfficeSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
