using System;

namespace DigitalOffice.Models.Contracts.Vacation
{
  public record VacationInfo
  {
    public Guid UserId { get; init; }
    public DateOnly StartDateUtc { get; init; }
    public DateOnly EndDateUtc { get; init; }
    public string Comment { get; init; }
    
    public VacationInfo(
      Guid userId,
      DateOnly startDateUtc,
      DateOnly endDateUtc,
      string comment)
    {
      UserId = userId;
      StartDateUtc = startDateUtc;
      EndDateUtc = endDateUtc;
      Comment = comment;
    }
  }
}