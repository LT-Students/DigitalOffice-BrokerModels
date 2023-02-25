using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Models.Company
{
  public class CompanyUserData
  {
    public Guid UserId { get; }
    public ContractSubjectData ContractSubject { get; }
    public ContractTerm ContractTermType { get; }
    public double? Rate { get; }
    public DateTime StartWorkingAt { get; }
    public DateTime? EndWorkingAt { get; }
    public DateTime? Probation { get; }
    public bool IsActive { get; }

    public CompanyUserData(
      Guid userId,
      ContractSubjectData contractSubject,
      ContractTerm contractTermType,
      double? rate,
      DateTime startWorkingAt,
      DateTime? endWorkingAt,
      DateTime? probation,
      bool isActive)
    {
      UserId = userId;
      ContractSubject = contractSubject;
      ContractTermType = contractTermType;
      Rate = rate;
      StartWorkingAt = startWorkingAt;
      EndWorkingAt = endWorkingAt;
      Probation = probation;
      IsActive = isActive;
    }
  }
}
