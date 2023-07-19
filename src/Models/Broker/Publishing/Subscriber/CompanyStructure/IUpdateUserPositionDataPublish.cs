using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;
public interface IUpdateUserPositionDataPublish
{
  Guid UserId { get; set; }
  Guid? PositionId { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    Guid userId,
    Guid? positionId,
    Guid modifiedBy)
  {
    return new
    {
      UserId = userId,
      PositionId = positionId,
      ModifiedBy = modifiedBy
    };
  }
}
