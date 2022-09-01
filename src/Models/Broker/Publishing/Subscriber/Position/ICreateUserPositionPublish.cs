using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Position
{
    public interface ICreateUserPositionPublish
    {
        Guid UserId { get; }
        Guid PositionId { get; }
        Guid CreatedBy { get; }
        bool IsActive { get; }

        static object CreateObj(Guid userId, Guid positionId, Guid createdBy, bool isActive = false)
        {
            return new
            {
                UserId = userId,
                PositionId = positionId,
                CreatedBy = createdBy,
                IsActive = isActive
            };
        }
    }
}
