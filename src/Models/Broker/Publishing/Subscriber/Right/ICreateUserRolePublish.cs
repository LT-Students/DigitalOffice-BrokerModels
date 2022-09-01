using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Right
{
    public interface ICreateUserRolePublish
    {
        Guid UserId { get; }
        Guid RoleId { get; }
        Guid CreatedBy { get; }
        bool IsActive { get; }

        static object CreateObj(Guid userId, Guid roleId, Guid createdBy, bool isActive = false)
        {
            return new
            {
                UserId = userId,
                RoleId = roleId,
                CreatedBy = createdBy,
                IsActive = isActive
            };
        }
    }
}
