using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Common
{
    public interface ICheckUsersExistence
    {
        List<Guid> UserIds { get; }

        static object CreateObj(List<Guid> userIds)
        {
            return new
            {
                UserIds = userIds
            };
        }
    }
}
