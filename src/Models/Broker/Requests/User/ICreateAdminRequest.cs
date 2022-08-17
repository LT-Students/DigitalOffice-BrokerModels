namespace LT.DigitalOffice.Models.Broker.Requests.User
{
    public interface ICreateAdminRequest
    {
        string FirstName { get; }
        string MiddleName { get; }
        string LastName { get; }
        string Email { get; }
        string Login { get; }
        string Password { get; }

        static object CreateObj(
            string firstName,
            string middleName,
            string lastName,
            string email,
            string login,
            string password)
        {
            return new
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Email = email,
                Login = login,
                Password = password
            };
        }
    }
}
