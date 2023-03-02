using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Wiki
{
    public interface ICheckFilesFromPublicArticleRequest
    {
        public List<Guid> FilesIds { get; }

        static object CreateObj(List<Guid> filesIds)
        {
            return new
            {
                FilesIds = filesIds
            };
        }
    }
}
