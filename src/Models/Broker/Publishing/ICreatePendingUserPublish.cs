using System;

namespace DigitalOffice.Models.Broker.Publishing
{
  public interface ICreatePendingUserPublish
  {
    Guid UserId { get; }
    Guid CreatedBy { get; }

    static object CreateObj(Guid userId, Guid createdBy)
    {
      return new
      {
        UserId = userId,
        CreatedBy = createdBy
      };
    }
  }
}
