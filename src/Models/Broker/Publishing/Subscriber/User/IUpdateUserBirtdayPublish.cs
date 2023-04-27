using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.User
{
    public interface IUpdateUserBirtdayPublish
    {
        Guid UserId { get; }
        DateTime? DateOfBirth { get; }

        static object CreateObj(Guid userId, DateTime dateOfBirth)
        {
            return new
            {
                UserId = userId,
                DateOfBirth = dateOfBirth
            };
        }
    }
}
