using DigitalOffice.Models.Broker.Models.User;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Filter
{
  public class IFilterUsersResponse
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
