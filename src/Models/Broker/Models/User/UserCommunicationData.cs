namespace DigitalOffice.Models.Broker.Models.User;

public class UserCommunicationData
{
  public int Type { get;}
  public string Value { get;}
  
  public UserCommunicationData(int type, string value)
  {
    Type = type;
    Value = value;
  }
}
