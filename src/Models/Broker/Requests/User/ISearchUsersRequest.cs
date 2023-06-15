namespace LT.DigitalOffice.Models.Broker.Requests.User
{
    public interface ISearchUsersRequest
    {
        string[] Value { get; }

        static object CreateObj(string[] value)
        {
            return new
            {
                Value = value
            };
        }
    }
}
