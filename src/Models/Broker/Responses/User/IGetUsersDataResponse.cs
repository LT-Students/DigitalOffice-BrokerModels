using LT.DigitalOffice.Models.Broker.Models;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.User
{
	public interface IGetUsersDataResponse
	{
		List<UserData> UsersData { get; }

		static object CreateObj(List<UserData> usersData)
		{
			return new
			{
				UsersData = usersData,
			};
		}
	}
}
