using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.User
{
	public interface IGetUsersDataRequest
	{
		List<Guid> UsersIds { get; }

		static object CreateObj(
			List<Guid> usersIds)
		{
			return new
			{
				UsersIds = usersIds
			};
		}
	}
}
