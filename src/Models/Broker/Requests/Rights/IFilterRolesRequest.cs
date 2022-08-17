using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Rights
{
	public interface IFilterRolesRequest
	{
        List<Guid> RolesIds { get; }

        static object CreateObj(List<Guid> rolesIds)
        {
            return new
            {
                RolesIds = rolesIds,
            };
        }
    }
}
