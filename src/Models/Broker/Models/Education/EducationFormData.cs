using System;

namespace LT.DigitalOffice.Models.Broker.Models.Education
{
    public class EducationFormData
    {
        public Guid Id { get; }
        public string Name { get; }

        public EducationFormData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
