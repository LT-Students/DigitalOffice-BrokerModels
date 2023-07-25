using DigitalOffice.Models.Broker.Models.User;
using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IRemoveUserCommunicationDataPublish
{
  Guid UserId { get; set; }
  UserCommunicationData CommunicationData { get; set; }

  static object CreateObj(
    Guid userId,
    UserCommunicationData communicationData)
  {
    return new
    {
      UserId = userId,
      CommunicationData = communicationData
    };
  }
}
