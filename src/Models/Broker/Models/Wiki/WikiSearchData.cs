using System;

namespace DigitalOffice.Models.Broker.Models.Wiki
{
    public class WikiSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public WikiSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
