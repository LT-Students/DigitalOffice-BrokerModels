using System;

namespace LT.DigitalOffice.Models.Broker.Responses.User
{
    public interface IGetUserCredentialsResponse
    {
        Guid UserId { get; }
        string PasswordHash { get; }
        string Salt { get; }
        string UserLogin { get; }

        static object CreateObj(
            Guid userId,
            string passwordHash,
            string salt,
            string userLogin)
        {
            return new
            {
                UserId = userId,
                PasswordHash = passwordHash,
                Salt = salt,
                UserLogin = userLogin
            };
        }
    }
}
