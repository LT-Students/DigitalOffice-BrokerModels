using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common
{
    public interface ICheckEventsExistence
    {
        List<Guid> EventsIds { get; }

        static object CreateObj(List<Guid> eventsIds)
        {
            return new
            {
                EventsIds = eventsIds
            };
        }
    }
}
