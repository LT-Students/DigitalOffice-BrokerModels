using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Project
{
    public interface IGetProjectUserRoleRequest
    {
        Guid ProjectId { get; }
        Guid UserId { get; }

        static object CreateObj(Guid projectId, Guid userId)
        {
            return new
            {
                ProjectId = projectId,
                UserId = userId
            };
        }
    }
}
