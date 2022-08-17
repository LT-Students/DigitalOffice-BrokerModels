using System;

namespace LT.DigitalOffice.Models.Broker.Publishing
{
    public interface IDisactivateUserPublish
    {
        Guid UserId { get; }
        Guid ModifiedBy { get; }

        static object CreateObj(Guid userId, Guid modifiedBy)
        {
            return new
            {
                UserId = userId,
                ModifiedBy = modifiedBy
            };
        }
    }
}
