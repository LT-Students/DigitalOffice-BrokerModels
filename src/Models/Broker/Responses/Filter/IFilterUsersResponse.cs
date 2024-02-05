using DigitalOffice.Models.Broker.Models.User;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Filter
{
  public interface IFilterUsersResponse
  {
    List<UserWithCommunicationData> Users { get; }

    static object CreateObj(List<UserData> users)
    {
      return new
      {
        Users = users,
      };
    }
  }
}
