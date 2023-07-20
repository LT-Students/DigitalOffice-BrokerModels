using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Company;

public interface ICreateCompanyUserPublish
{
  Guid CompanyId { get; }
  Guid UserId { get; }
  public Guid? ContractSubjectId { get; }
  public ContractTerm ContractTermType { get; }
  double? Rate { get; }
  DateTime StartWorkingAt { get; }
  public DateTime? EndWorkingAt { get; }
  public DateTime? Probation { get; }
  Guid CreatedBy { get; }
  bool IsActive { get; }

  static object CreateObj(
      Guid companyId,
      Guid userId,
      Guid? contractSubjectId,
      ContractTerm contractTermType,
      double? rate,
      DateTime startWorkingAt,
      DateTime? endWorkingAt,
      DateTime? probation,
      Guid createdBy,
      bool isActive = false)
  {
    return new
    {
      CompanyId = companyId,
      UserId = userId,
      contractSubjectId = contractSubjectId,
      contractTermType = contractTermType,
      Rate = rate,
      StartWorkingAt = startWorkingAt,
      EndWorkingAt = endWorkingAt,
      Probation = probation,
      CreatedBy = createdBy,
      IsActive = isActive
    };
  }
}
