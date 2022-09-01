using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Office
{
    public interface ICreateUserOfficePublish
    {
        Guid UserId { get; set; }
        Guid OfficeId { get; set; }
        Guid CreatedBy { get; set; }
        bool IsActive { get; }

        static object CreateObj(
            Guid userId,
            Guid officeId,
            Guid createdBy,
            bool isActive)
        {
            return new
            {
                UserId = userId,
                OfficeId = officeId,
                CreatedBy = createdBy,
                IsActive = isActive
            };
        }
    }
}
