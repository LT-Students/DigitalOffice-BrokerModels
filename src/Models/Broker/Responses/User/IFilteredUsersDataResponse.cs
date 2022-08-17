using LT.DigitalOffice.Models.Broker.Models;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.User
{
	public interface IFilteredUsersDataResponse
	{
		List<UserData> UsersData { get; }
		int TotalCount { get; }

		static object CreateObj(List<UserData> usersData, int totalCount)
		{
			return new
			{
				UsersData = usersData,
				TotalCount = totalCount
			};
		}
	}
}
