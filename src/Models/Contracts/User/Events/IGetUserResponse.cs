namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IGetUserResponse
  {
    UserInfo User { get; }

    static object CreateObj(UserInfo user)
    {
      return new
      {
        User = user
      };
    }
  }
}
