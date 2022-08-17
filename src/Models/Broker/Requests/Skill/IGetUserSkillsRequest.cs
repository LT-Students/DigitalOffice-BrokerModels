using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Skill
{
    public interface IGetUserSkillsRequest
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
