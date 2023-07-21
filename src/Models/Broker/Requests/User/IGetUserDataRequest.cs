using System;

namespace LT.DigitalOffice.Models.Broker.Requests.User;

public interface IGetUserDataRequest
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
