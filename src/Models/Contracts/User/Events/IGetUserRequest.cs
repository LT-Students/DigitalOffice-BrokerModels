using System;

namespace DigitalOffice.Models.Contracts.User.Events
{
  public interface IGetUserRequest
  {
    Guid UserId { get; }

    static object CreateObj(Guid userId)
    {
      return new
      {
        UserId = userId
      };
    }
  }
}
