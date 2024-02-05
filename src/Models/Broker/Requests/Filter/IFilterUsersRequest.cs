using System;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterUsersRequest
  {
    string FullNameIncludeSubstring { get; }
    bool? IsActive { get; }
    bool? IsPending { get; }
    Guid? GenderId { get; }
    bool IncludeCommunications { get; }

    static object CreateObj(
      string fullNameIncludeSubstring = null,
      bool? isActive = true,
      Guid? genderId = null,
      bool? isPending = null,
      bool includeCommunications = false)
    {
      return new {
        FullNameIncludeSubstring = fullNameIncludeSubstring,
        IsActive = isActive,
        IsPending = isPending,
        GenderId = genderId,
        IncludeCommunications = includeCommunications
      };
    }
  }
}
