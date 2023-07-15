using DigitalOffice.Models.Broker.Models.Department;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IUpdateDepartmentUsersDataPublish
{
  List<DepartmentUserPublishData> UsersData { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    List<DepartmentUserPublishData> usersData,
    Guid modifiedBy)
  {
    return new
    {
      UsersData = usersData,
      ModifiedBy = modifiedBy
    };
  }
}
