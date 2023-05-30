using System;

namespace DigitalOffice.Models.Broker.Models.Project
{
    public class ProjectSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public ProjectSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
