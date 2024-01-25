using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.User;

public interface IFilteredUsersDataRequest
{
  List<Guid> UsersIds { get; }
  int SkipCount { get; }
  int TakeCount { get; }
  bool? AscendingSort { get; }
  string FullNameIncludeSubstring { get; }
  bool? IsActive { get; }
  bool? IsPending { get; }
  Guid? GenderId { get; }

  static object CreateObj(
    List<Guid> usersIds,
    int skipCount = 0,
    int takeCount = 1,
    bool? ascendingSort = null,
    string fullNameIncludeSubstring = null,
    bool? isActive = true,
    Guid? genderId = null,
    bool? isPending = null)
  {
    return new
    {
      UsersIds = usersIds,
      SkipCount = skipCount,
      TakeCount = takeCount,
      AscendingSort = ascendingSort,
      FullNameIncludeSubstring = fullNameIncludeSubstring,
      IsActive = isActive,
      IsPending = isPending,
      GenderId = genderId,
    };
  }
}
