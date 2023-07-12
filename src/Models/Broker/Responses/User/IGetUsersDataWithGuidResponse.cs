using DigitalOffice.Models.Broker.Models.User;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.User
{
    public interface IGetUsersDataDictionaryResponse
    {
        Dictionary<Guid, UserData> UsersData { get; }

        static object CreateObj(Dictionary<Guid, UserData> usersData)
        {
            return new
            {
                UsersData = usersData,
            };
        }
    }
}
