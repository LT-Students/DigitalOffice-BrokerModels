namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IGetUsersRequest
  {
    public GetUsersFilter Filter { get; }

    static object CreateObj(GetUsersFilter filter)
    {
      return new
      {
        Filter = filter
      };
    }
  }
}
