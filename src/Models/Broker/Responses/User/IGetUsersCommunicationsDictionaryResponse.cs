using DigitalOffice.Models.Broker.Models.User;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.User;

public interface IGetUsersCommunicationsDictionaryResponse
{
  Dictionary<Guid, List<UserCommunicationData>> UsersCommunications { get; }

  static object CreateObj(Dictionary<Guid, List<UserCommunicationData>> usersCommunications)
  {
    return new
    {
      UsersCommunications = usersCommunications,
    };
  }
}
