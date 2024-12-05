namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IUserUpdated
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
