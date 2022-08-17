using System;

namespace LT.DigitalOffice.Models.Broker.Models
{
    public class SearchInfo
    {
        public Guid Id { get; }
        public string Value { get; }

        public SearchInfo(Guid id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
