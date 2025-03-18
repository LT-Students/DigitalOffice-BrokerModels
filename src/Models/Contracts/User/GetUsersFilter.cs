using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.User
{
  public class GetUsersFilter
  {
    public List<Guid> UserIds { get; set; }
    public string FullNameIncludeSubstring { get; set; }
    public string GenderIncludeSubstring { get; set; }
    public DateOnly? BirthDateAfter { get; set; }
    public DateOnly? BirthDateBefore { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsPending { get; set; }
    public bool? IsAdmin { get; set; }
    public bool? IncludeCommunications { get; set; }
    public bool? IncludeRemoveDate { get; set; }
  }
}
