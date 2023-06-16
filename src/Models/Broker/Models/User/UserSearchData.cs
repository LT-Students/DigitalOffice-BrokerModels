using System;

namespace DigitalOffice.Models.Broker.Models.User
{
    public class UserSearchData
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }

        public UserSearchData(Guid id, string firstName, string lastName, string middleName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
    }
}
