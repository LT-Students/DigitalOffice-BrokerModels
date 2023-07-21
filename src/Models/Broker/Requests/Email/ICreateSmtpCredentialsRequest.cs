namespace LT.DigitalOffice.Models.Broker.Requests.Email;

public interface ICreateSmtpCredentialsRequest
{
  string Host { get; }
  int Port { get; }
  bool EnableSsl { get; }
  string Email { get; }
  string Password { get; }

  static object CreateObj(
      string host,
      int port,
      bool enableSsl,
      string email,
      string password)
  {
    return new
    {
      Host = host,
      Port = port,
      EnableSsl = enableSsl,
      Email = email,
      Password = password
    };
  }
}
