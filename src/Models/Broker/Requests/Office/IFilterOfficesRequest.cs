using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Office
{
	public interface IFilterOfficesRequest
	{
        List<Guid> OfficesIds { get; }

        static object CreateObj(List<Guid> officesIds)
        {
            return new
            {
                OfficesIds = officesIds,
            };
        }
    }
}
