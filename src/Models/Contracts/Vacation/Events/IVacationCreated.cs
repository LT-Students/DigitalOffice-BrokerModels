using System;

namespace DigitalOffice.Models.Contracts.Vacation.Events
{
  public interface IVacationCreated
  {
    VacationInfo Vacation { get; }
    Guid CreatorId { get; }

    static object CreateObj(
      VacationInfo vacation,
      Guid creatorId)
    {
      return new
      {
        Vacation = vacation,
        CreatorId = creatorId
      };
    }
  }
}