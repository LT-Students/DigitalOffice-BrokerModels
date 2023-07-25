using System;

namespace DigitalOffice.Models.Broker.Models.Wiki
{
    public class RubricSearchData
    {
        public Guid Id { get; }
        public string Name { get; }

        public RubricSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
