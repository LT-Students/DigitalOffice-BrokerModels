namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IUserCreated
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
