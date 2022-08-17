using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Education
{
    public interface IGetUserEducationsRequest
    {
        Guid UserId { get; }

        static object CreateObj(
            Guid userId)
        {
            return new
            {
                UserId = userId
            };
        }
    }
}
