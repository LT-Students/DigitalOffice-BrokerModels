using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Survey;

public interface IGetSurveyUsersResponse
{
  List<Guid> UsersIds { get; }

  static object CreateObj(List<Guid> usersIds)
  {
    return new
    {
      UsersIds = usersIds
    };
  }
}
