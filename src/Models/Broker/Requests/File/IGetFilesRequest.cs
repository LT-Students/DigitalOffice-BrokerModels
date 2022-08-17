using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.File
{
    public interface IGetFilesRequest
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
