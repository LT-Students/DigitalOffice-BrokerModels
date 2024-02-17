using System;

namespace DigitalOffice.Models.Broker.Models.User;

public class UserCommunicationData
{
  public Guid? CommunicationId { get; }
  public int Type { get; }
  public string Value { get; }
  
  public UserCommunicationData(int type, string value, Guid? communicationId = null)
  {
    CommunicationId = communicationId;
    Type = type;
    Value = value;
  }
}
