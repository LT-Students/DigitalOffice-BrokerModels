using System;

namespace DigitalOffice.Models.Broker.Models.User
{
    public class UserBirthday
    {
        public Guid UserId { get; }
        public DateTime DateOfBirth { get; }

        public UserBirthday(
            Guid userId,
            DateTime dateOfBirth)
        {
            UserId = userId;
            DateOfBirth = dateOfBirth;
        }
    }
}
