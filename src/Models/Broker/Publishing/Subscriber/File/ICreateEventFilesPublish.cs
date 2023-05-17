using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.File
{
    public interface ICreateEventFilesPublish
    {
        List<Guid> FilesIds { get; }
        Guid EventId { get; }

        static object CreateObj(List<Guid> filesIds, Guid eventId)
        {
            return new
            {
                FilesIds = filesIds,
                EventId = eventId
            };
        }
    }
}
