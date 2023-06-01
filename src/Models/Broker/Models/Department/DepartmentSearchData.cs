using System;

namespace DigitalOffice.Models.Broker.Models.Department
{
    public class DepartmentSearchData
    {
        public Guid Id { get; }
        public string Name { get; }
        public DepartmentSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
