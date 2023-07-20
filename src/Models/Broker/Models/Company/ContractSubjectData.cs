using System;

namespace LT.DigitalOffice.Models.Broker.Models.Company;

public class ContractSubjectData
{
  public Guid Id { get; }
  public string Name { get; }
  public bool IsActive { get; }

  public ContractSubjectData(
    Guid id,
    string name,
    bool isActive)
  {
    Id = id;
    Name = name;
    IsActive = isActive;
  }
}
