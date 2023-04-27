using System;

namespace DigitalOffice.Models.Broker.Publishing
{
    public interface IUpdateUserBirtdayPublish
    {
        Guid UserId { get; }
        DateTime? DateOfBirth { get; }
        bool IsActive { get; }

        static object CreateObj(Guid userId, DateTime dateOfBirth, bool isActive)
        {
            return new
            {
                UserId = userId,
                DateOfBirth = dateOfBirth,
                IsActive = isActive
            };
        }
    }
}
