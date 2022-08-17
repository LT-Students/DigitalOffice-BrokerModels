using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Office
{
	public class OfficeFilteredData
	{
        public Guid Id { get; }
        public string Name { get; }
        public List<Guid> UsersIds { get; }

        public OfficeFilteredData(Guid id, string name, List<Guid> usersIds)
        {
            Id = id;
            Name = name;
            UsersIds = usersIds;
        }
    }
}
