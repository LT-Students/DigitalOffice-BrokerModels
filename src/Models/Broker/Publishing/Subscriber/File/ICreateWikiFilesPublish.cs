using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.File
{
    public interface ICreateWikiFilesPublish
    {
        List<Guid> FilesIds { get; }
        Guid ArticleId { get; }

        static object CreateObj(List<Guid> filesIds, Guid articleId)
        {
            return new
            {
                FilesIds = filesIds,
                ArticleId = articleId
            };
        }
    }
}
