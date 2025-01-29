using System;

namespace DigitalOffice.Models.Contracts.Vacation.Events
{
  public interface IVacationDeleted
  {
    VacationInfo Vacation { get; }
    Guid ModifierId { get; }

    static object CreateObj(
      VacationInfo vacation,
      Guid modifierId)
    {
      return new
      {
        Vacation = vacation,
        ModifierId = modifierId
      };
    }
  }
}