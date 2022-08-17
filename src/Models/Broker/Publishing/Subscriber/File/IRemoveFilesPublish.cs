using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.File
{
    public interface IRemoveFilesPublish
    {
        List<Guid> FilesIds { get; }

        static object CreateObj(List<Guid> filesIds)
        {
            return new
            {
                FilesIds = filesIds
            };
        }
    }
}
