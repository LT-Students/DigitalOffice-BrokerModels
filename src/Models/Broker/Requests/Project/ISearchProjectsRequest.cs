namespace LT.DigitalOffice.Models.Broker.Requests.Project
{
    public interface ISearchProjectsRequest
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
