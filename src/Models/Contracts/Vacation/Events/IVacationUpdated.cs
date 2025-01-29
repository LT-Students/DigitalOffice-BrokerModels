using System;

namespace DigitalOffice.Models.Contracts.Vacation.Events
{
  public interface IVacationUpdated
  {
    VacationInfo VacationBeforeUpdate { get; }
    VacationInfo VacationAfterUpdate { get; }
    Guid ModifierId { get; }
    
    static object CreateObj(
      VacationInfo vacationBeforeUpdate,
      VacationInfo vacationAfterUpdate,
      Guid modifierId)
    {
      return new
      {
        VacationBeforeUpdate = vacationBeforeUpdate,
        VacationAfterUpdate = vacationAfterUpdate,
        ModifierId = modifierId
      };
    }
  }
}