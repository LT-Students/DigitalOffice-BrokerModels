using System;

namespace LT.DigitalOffice.Models.Broker.Models
{
    public class UserData
    {
        public Guid Id { get; }
        public Guid? ImageId { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public bool IsActive { get; }
        public string Email { get; }

        public UserData(
            Guid id,
            Guid? imageId,
            string firstName,
            string middleName,
            string lastName,
            bool isActive,
            string email)
        {
            Id = id;
            ImageId = imageId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            IsActive = isActive;
            Email = email;
        }
    }
}
