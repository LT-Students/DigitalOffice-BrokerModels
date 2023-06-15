using System;

namespace DigitalOffice.Models.Broker.Models.Office
{
    public class OfficeSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Address { get; }
        public string StartTime { get; }
        public string EndTime { get; }
        public OfficeSearchData(Guid id, string name, string address, string startTime, string endTime)
        {
            Id = id;
            Name = name;
            Address = address;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
