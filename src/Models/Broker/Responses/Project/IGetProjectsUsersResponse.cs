using LT.DigitalOffice.Models.Broker.Models.Project;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Project
{
	public interface IGetProjectsUsersResponse
    {
        List<ProjectUserData> Users { get; }
        int TotalCount { get; }

        static object CreateObj(
            List<ProjectUserData> users,
            int totalCount)
        {
            return new
            {
                Users = users,
                TotalCount = totalCount
            };
        }
    }
}
