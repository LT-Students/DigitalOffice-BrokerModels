using System;

namespace LT.DigitalOffice.Models.Broker.Models.Company
{
    public class ContractSubjectData
    {
        public Guid Id { get; }
        public string Name { get; }

        public ContractSubjectData(
            Guid id,
            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
