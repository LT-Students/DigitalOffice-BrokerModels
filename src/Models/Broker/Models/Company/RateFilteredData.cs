using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Company;

public class RateFilteredData
{
  public double Rate { get; }
  public List<Guid> UsersIds { get; }

  public RateFilteredData(double rate, List<Guid> usersIds)
  {
    Rate = rate;
    UsersIds = usersIds;
  }
}