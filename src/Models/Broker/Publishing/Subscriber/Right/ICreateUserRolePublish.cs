using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Right
{
    public interface ICreateUserRolePublish
    {
        Guid RoleId { get; }
        Guid UserId { get; }
        Guid ChangedBy { get; }

        static object CreateObj(Guid roleId, Guid userId, Guid changedBy)
        {
            return new
            {
                RoleId = roleId,
                UserId = userId,
                ChangedBy = changedBy
            };
        }
    }
}
