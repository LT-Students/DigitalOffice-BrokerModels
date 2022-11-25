using DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.File
{
    public interface IRemoveFilesPublish
    {
        FileSource FileSource { get; }
        List<Guid> FilesIds { get; }

        static object CreateObj(FileSource fileSource, List<Guid> filesIds)
        {
            return new
            {
                FileSource = fileSource,
                FilesIds = filesIds
            };
        }
    }
}
