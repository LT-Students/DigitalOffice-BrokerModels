using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Company;

public class CompanyData
{
  public Guid Id { get; }
  public string Name { get; }
  public List<CompanyUserData> Users { get; }

  public CompanyData(Guid id, string name, List<CompanyUserData> users)
  {
    Id = id;
    Name = name;
    Users = users;
  }
}
