namespace LT.DigitalOffice.Models.Broker.Requests.User;

public interface IGetUserCredentialsRequest
{
  string LoginData { get; }

  static object CreateObj(string loginData)
  {
    return new
    {
      LoginData = loginData
    };
  }
}
