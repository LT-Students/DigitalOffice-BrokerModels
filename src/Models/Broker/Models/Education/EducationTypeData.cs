using System;

namespace LT.DigitalOffice.Models.Broker.Models.Education
{
    public class EducationTypeData
    {
        public Guid Id { get; }
        public string Name { get; }

        public EducationTypeData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
