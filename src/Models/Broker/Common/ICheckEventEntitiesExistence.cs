using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common
{
    public interface ICheckEventEntitiesExistence
    {
        List<Guid> EntitiesIds { get; }

        static object CreateObj(List<Guid> entitiesIds)
        {
            return new
            {
                EntitiesIds = entitiesIds
            };
        }
    }
}
