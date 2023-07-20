using DigitalOffice.Models.Broker.Models.User;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.User;

public interface IGetUsersBirthdaysResponse
{
  List<UserBirthday> UsersBirthdays { get; }

  static object CreateObj(List<UserBirthday> usersBirthdays)
  {
    return new
    {
      UsersBirthdays = usersBirthdays,
    };
  }
}
