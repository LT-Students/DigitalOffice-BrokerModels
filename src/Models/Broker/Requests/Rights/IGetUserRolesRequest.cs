using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Rights
{
    public interface IGetUserRolesRequest
    {
        List<Guid> UserIds { get; }
        string Locale { get; }

        static object CreateObj(List<Guid> userIds, string locale)
        {
            return new
            {
                UserIds = userIds,
                Locale = locale
            };
        }
    }
}
