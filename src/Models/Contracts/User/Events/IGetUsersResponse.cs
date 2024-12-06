using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IGetUsersResponse
  {
    public List<UserInfo> Users { get; }

    static object CreateObj(List<UserInfo> users)
    {
      return new
      {
        Users = users
      };
    }
  }
}
