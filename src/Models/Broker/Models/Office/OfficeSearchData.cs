using System;

namespace DigitalOffice.Models.Broker.Models.Office
{
    public class OfficeSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Address { get; }
        public OfficeSearchData(Guid id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
