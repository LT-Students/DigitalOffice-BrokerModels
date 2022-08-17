using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Company
{
    public interface IGetCompaniesRequest
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
