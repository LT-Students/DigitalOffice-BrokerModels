using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Position
{
    public interface ICreateUserPositionPublish
    {
        Guid UserId { get; }
        Guid PositionId { get; }
        Guid CreatedBy { get; }

        static object CreateObj(Guid userId, Guid positionId, Guid createdBy)
        {
            return new
            {
                UserId = userId,
                PositionId = positionId,
                CreatedBy = createdBy
            };
        }
    }
}
