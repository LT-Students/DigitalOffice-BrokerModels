using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Project
{
    public interface ICheckProjectUsersExistenceRequest
    {
        Guid ProjectId { get; set; }
        List<Guid> UsersIds { get; }

        static object CreateObj(Guid projectId, List<Guid> usersIds)
        {
            return new
            {
                ProjectId = projectId,
                UsersIds = usersIds
            };
        }
    }
}
