using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Office
{
    public interface ICheckWorkspaceIsBookableRequest
    {
        Guid WorkspaceId { get; }

        static object CreateObj(Guid workspaceId)
        {
            return new
            {
                WorkspaceId = workspaceId
            };
        }
    }
}
