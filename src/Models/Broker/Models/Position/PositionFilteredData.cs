using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Position
{
	public class PositionFilteredData
	{
        public Guid Id { get; }
        public string Name { get; }
        public List<Guid> UsersIds { get; }

        public PositionFilteredData(Guid id, string name, List<Guid> usersIds)
        {
            Id = id;
            Name = name;
            UsersIds = usersIds;
        }
    }
}
