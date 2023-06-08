using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.File
{
    public interface ICreateEventEntitiesFilesPublish
    {
        List<Guid> FilesIds { get; }
        Guid EntityId { get; }

        static object CreateObj(List<Guid> filesIds, Guid entityId)
        {
            return new
            {
                FilesIds = filesIds,
                EntityId = entityId
            };
        }
    }
}
