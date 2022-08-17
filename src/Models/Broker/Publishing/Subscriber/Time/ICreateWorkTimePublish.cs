using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Time
{
    public interface ICreateWorkTimePublish
    {
        Guid ProjectId { get; }
        List<Guid> UserIds { get; }

        static object CreateObj(Guid projectId, List<Guid> userIds)
        {
            return new
            {
                ProjectId = projectId,
                UserIds = userIds
            };
        }
    }
}
