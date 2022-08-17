using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Position
{
    public interface IGetPositionsRequest
    {
        List<Guid> UsersIds { get; }

        static object CreateObj(
            List<Guid> usersIds = null)
        {
            return new
            {
                UsersIds = usersIds
            };
        }
    }
}