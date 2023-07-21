using System;

namespace DigitalOffice.Models.Broker.Publishing;

public interface IActivateUserPublish
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
