using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Models.User
{
  public class UserWithCommunicationData
  {
    public UserData User { get; }
    public List<UserCommunicationData> Communications { get; }

    public UserWithCommunicationData(UserData user, List<UserCommunicationData> communications)
    {
      User = user;
      Communications = communications;
    }
  }
}
